using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Web.Pages;

public class BlogPostPageModel(IBlogPostService blogPostService) : PageModel
{
    private readonly IBlogPostService _blogPostService = blogPostService;

    public BlogPostModel? BlogPost { get; set; }

    public async Task<IActionResult> OnGet(string slug)
    {
        BlogPost = await _blogPostService.GetBlogPostBySlug(slug);

        if (BlogPost == null)
            return NotFound();

        ViewData["Title"] = BlogPost.Title;
        ViewData["MetaDescription"] = BlogPost.MetaDescription;

        return Page();
    }
}
