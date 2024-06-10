using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Blog.Pages;

public class BlogsIndexModel : BasePageModel
{
    public BlogsIndexModel(ApplicationSettings applicationSettings) : base(applicationSettings)
    {
    }

    public void OnGet()
    {
    }
}
