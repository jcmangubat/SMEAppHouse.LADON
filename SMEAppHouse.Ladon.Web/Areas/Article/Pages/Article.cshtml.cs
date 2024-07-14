using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Core.CodeKits;
using SMEAppHouse.Core.CodeKits.Extensions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class ArticlePageModel(ApplicationSettings applicationSettings,
                            IArticleService articleService,
                            IArticleMetricsService articleMetricService) :
    BasePageModel(applicationSettings)
{
    private readonly IArticleService _articleService = articleService;
    private readonly IArticleMetricsService _articleMetricsService = articleMetricService;

    public ArticleModel? Article { get; set; }
    public List<ArticleModel> LatestArticles { get; set; }

    public async Task<IActionResult> OnGet(string title)
    {
        var slug = CodeKit.MakeSlug(title);

        // Fetch the blog article based on the title slug
        Article = await _articleService.GetArticleBySlug(slug) ?? throw new Exception("Article not found.");
        LatestArticles = (await _articleService.GetArticlesAsync(filter: null, articleCount: 6))?.ToList() ?? [];
        LatestArticles = LatestArticles
                            .Where(a => !a.Slug.EqualsCaseInsensitive(Article.Slug))
                            .OrderByDescending(a => a.PublishedDate ?? DateTime.Now)
                            .Take(5)
                            .ToList();

        if (Article == null)
            return RedirectToPage("/Error");

        await _articleMetricsService.TrackViewAsync(articleId: Article.Id ?? Guid.Empty);

        // Set dynamic meta tags
        ViewData["Title"] = Article.Title;
        ViewData["Description"] = Article.MetaDescription;

        return Page();
    }

    public async Task<JsonResult> OnPostReactionAsync(Guid articleId, ReaderReactionsEnum reaction)
    {
        try
        {
            await _articleMetricsService.TrackReactionAsync(articleId, reaction);
            var article = await _articleService.GetArticleAsync(articleId);
            return article == null
                ? throw new Exception($"failed to tracking reaction {reaction} for this article.")
                : new JsonResult(new
                {
                    success = true,
                    views = article.Views,
                    likes = article.Likes,
                    hearts = article.Hearts,
                    comments = article.Comments?.Count ?? 0
                });
        }
        catch (Exception ex)
        {
            return new JsonResult(new
            {
                success = false,
                reason = ex.Message
            });
        }
    }
}
