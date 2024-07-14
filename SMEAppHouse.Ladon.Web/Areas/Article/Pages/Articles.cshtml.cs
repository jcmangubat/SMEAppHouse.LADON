using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class ArticlesPageModel(ApplicationSettings applicationSettings,
                                IWebHostEnvironment environment,
                                IArticleService articleService)
    : BasePageModel(applicationSettings)
{
    private readonly IArticleService _articleService = articleService;
    private readonly IWebHostEnvironment _environment = environment;

    public ArticleModel TopNews { get; private set; }
    public List<ArticleModel> SideNews { get; private set; } = [];
    public List<ArticleModel> LatestNonNewsArticles { get; private set; } = [];
    public List<ArticleModel> ArchivedArticles { get; private set; } = [];

    public async Task<IActionResult> OnGetAsync()
    {
        //Get news articles
        var newsArticles = await _articleService.GetNewsArticlesAsync(6);

        if (newsArticles != null && newsArticles.Any())
        {
            TopNews = newsArticles.First();
            SideNews = newsArticles.Skip(1).ToList();
        }

        LatestNonNewsArticles = (await _articleService.GetArticlesAsync(
                                    filter: a => (
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Feature ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Opinion ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Blog ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Interview ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Tutorial ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Review ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.CaseStudy ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Report
                                    ) && a.IsActive == true
                                    && (
                                        a.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Featured ||
                                        a.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Promoted ||
                                        a.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Published
                                    ),
                                    articleCount: 6)
                                )?.ToList() ?? [];


        ArchivedArticles = (await _articleService.GetArticlesAsync(
                                    filter: a => (
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Feature ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Opinion ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Blog ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Interview ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Tutorial ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Review ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.CaseStudy ||
                                        a.ArticleType == Domain.Constants.Rules.ArticleTypesEnum.Report
                                    )
                                    && a.IsActive == true
                                    && a.ArticleStatus == Domain.Constants.Rules.ArticleStatusEnum.Archived,
                                    articleCount: 6)
                                )?.ToList() ?? [];

        // Set dynamic meta tags
        ViewData["Title"] = "LCS Blog Index";
        ViewData["Description"] = "LCS Blog Index";

        return Page();
    }
}
