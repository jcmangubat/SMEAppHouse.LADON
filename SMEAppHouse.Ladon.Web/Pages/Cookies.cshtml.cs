using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Pages
{
    public class CookiesModel(ILogger<CookiesModel> logger, ApplicationSettings applicationSettings)
        : BasePageModel(applicationSettings)
    {
        private readonly ILogger<CookiesModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
