using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.ViewModels;

public class UserAuthenticationDetails
{
    public string? UserName { get; internal set; }
    public bool IsAuthenticated { get; set; }
    public bool HasAdminRole { get; set; }
    public bool HasManagerRole { get; set; }
    public bool HasEditorRole { get; set; }
    public bool HasModeratorRole { get; set; }
    public bool HasClientRole { get; set; }

    public UserProfile? UserProfile { get; set;}

}