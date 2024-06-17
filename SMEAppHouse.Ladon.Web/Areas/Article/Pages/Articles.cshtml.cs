using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class ArticlesModel(ApplicationSettings applicationSettings, 
                                IArticleService articleService) 
    : BasePageModel(applicationSettings)
{
    private readonly IArticleService _articleService = articleService;
    
    public Application.Models.Data.ArticleModel TopNews { get; set; }
    public List<Application.Models.Data.ArticleModel> SideNews { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        //Get news articles
        var newsArticles = await _articleService.GetNewsArticlesAsync(6);

        if (newsArticles != null && newsArticles.Any())
        {
            TopNews = newsArticles.First();
            SideNews = newsArticles.Skip(1).ToList();
        }

        // Set dynamic meta tags
        ViewData["Title"] = "LCS Blog Index";
        ViewData["Description"] = "LCS Blog Index";

        return Page();
    }
}
