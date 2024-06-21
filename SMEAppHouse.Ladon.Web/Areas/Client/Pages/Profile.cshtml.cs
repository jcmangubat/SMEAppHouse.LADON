using Microsoft.AspNetCore.Authorization;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Client.Pages;


[Authorize(Policy = "ClientOrAdmin")]
public class ProfilePageModel(ApplicationSettings applicationSettings) 
    : BasePageModel(applicationSettings)
{
    public void OnGet()
    {
    }
}
