using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SMEAppHouse.Ladon.Web.Pages
{
    public class CookiesModel : PageModel
    {
        private readonly ILogger<CookiesModel> _logger;

        public CookiesModel(ILogger<CookiesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
