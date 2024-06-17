using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class ArticlePageModel(ApplicationSettings applicationSettings,
                            IArticleService articleService,
                            IArticleMetricsService articleMetricService) :
    BasePageModel(applicationSettings)
{
    private readonly IArticleService _articleService = articleService;
    private readonly IArticleMetricsService _articleMetricsService = articleMetricService;

    public Application.Models.Data.ArticleModel Article { get; set; }

    public async Task<IActionResult> OnGet(string title)
    {
        var slug = Application.Models.Data.ArticleModel.MakeSlug(title);

        // Fetch the blog article based on the title
        Article = await _articleService.GetArticleBySlug(slug);

        if (Article == null)
            return RedirectToPage("/Error");

        await _articleMetricsService.TrackViewAsync(articleId: Article.Id ?? Guid.Empty);

        // Set dynamic meta tags
        ViewData["Title"] = Article.Title;
        ViewData["Description"] = Article.MetaDescription;

        return Page();
    }

    public async Task OnPostLikeAsync(string slug)
    {
        var article = await _articleService.GetArticleBySlug(slug);
        if (article == null)
            return;

        await _articleMetricsService.TrackViewAsync(articleId: article.Id ?? Guid.Empty);
    }
}
