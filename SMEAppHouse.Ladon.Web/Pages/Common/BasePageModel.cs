using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Web.Pages.Common
{
    public class BasePageModel(ApplicationSettings applicationSettings) : PageModel
    {
        protected readonly ApplicationSettings _applicationSettings = applicationSettings;

        public ApplicationSettings ApplicationSettings => _applicationSettings;
    }
}
