using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SMEAppHouse.Ladon.Web.Pages
{
    public class IndexModel(ILogger<IndexModel> logger) : PageModel
    {   
        public void OnGet()
        {
            logger.Log(LogLevel.Information, "");
        }
    }
}
