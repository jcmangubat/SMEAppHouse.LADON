using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.Application.Interfaces;

namespace SMEAppHouse.Ladon.Web.Pages;

public class BlogPostPageModel(IBlogPostService blogPostService) : PageModel
{
    private readonly IBlogPostService _blogPostService = blogPostService;

    public Application.Models.BlogPostModel? BlogPost { get; set; }

    public async Task<IActionResult> OnGet(string slug)
    {
        BlogPost = await _blogPostService.GetPostBySlug(slug);

        if (BlogPost == null)
            return NotFound();

        ViewData["Title"] = BlogPost.Title;
        ViewData["MetaDescription"] = BlogPost.MetaDescription;

        return Page();
    }
}
