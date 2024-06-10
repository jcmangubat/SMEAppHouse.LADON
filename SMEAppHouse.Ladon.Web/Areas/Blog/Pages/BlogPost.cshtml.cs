using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Blog.Pages;

public class BlogPostModel : BasePageModel
{
    private readonly IBlogPostService _blogPostService;

    public BlogPostModel(ApplicationSettings applicationSettings, IBlogPostService blogPostService)
        : base(applicationSettings)
    {
        _blogPostService = blogPostService;
    }

    public Application.Models.Data.BlogPostModel Post { get; set; }

    public async Task<IActionResult> OnGet(string title)
    {
        var slug = Application.Models.Data.BlogPostModel.MakeSlug(title);

        // Fetch the blog post based on the title
        Post = await _blogPostService.GetBlogPostBySlug(slug);

        if (Post == null)
            return RedirectToPage("/Error");

        // Set dynamic meta tags
        ViewData["Title"] = Post.Title;
        ViewData["Description"] = Post.MetaDescription;

        return Page();
    }
}
