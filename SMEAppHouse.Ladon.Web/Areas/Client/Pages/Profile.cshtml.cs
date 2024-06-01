using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SMEAppHouse.Ladon.Web.Areas.Client.Pages;


[Authorize(Policy = "ClientOrAdmin")]
public class ProfileModel : PageModel
{
    public void OnGet()
    {
    }
}
