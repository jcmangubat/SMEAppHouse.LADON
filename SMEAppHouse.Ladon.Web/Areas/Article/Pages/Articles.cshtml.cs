using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class ArticlesModel : BasePageModel
{
    public ArticlesModel(ApplicationSettings applicationSettings) : base(applicationSettings)
    {
    }

    public void OnGet()
    {
    }
}
