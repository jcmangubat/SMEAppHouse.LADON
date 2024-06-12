using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class ArticleModel : BasePageModel
{
    private readonly IArticleService _articleService;

    public ArticleModel(ApplicationSettings applicationSettings, IArticleService articleService)
        : base(applicationSettings)
    {
        _articleService = articleService;
    }

    public Application.Models.Data.ArticleModel Article { get; set; }

    public async Task<IActionResult> OnGet(string title)
    {
        var slug = Application.Models.Data.ArticleModel.MakeSlug(title);

        // Fetch the blog article based on the title
        Article = await _articleService.GetArticleBySlug(slug);

        if (Article == null)
            return RedirectToPage("/Error");

        // Set dynamic meta tags
        ViewData["Title"] = Article.Title;
        ViewData["Description"] = Article.MetaDescription;

        return Page();
    }
}
