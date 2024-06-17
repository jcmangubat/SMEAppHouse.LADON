using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Pages
{
    public class PrivacyModel(ILogger<PrivacyModel> logger, ApplicationSettings applicationSettings) :
    BasePageModel(applicationSettings)
    {
        private readonly ILogger<PrivacyModel> _logger = logger;

        public void OnGet()
        {
        }
    }

}
