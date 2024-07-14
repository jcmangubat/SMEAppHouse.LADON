using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class ResendEmailConfirmationConfirmPageModel(
                                    ApplicationSettings settings) : BasePageModel(settings)
{
    public string Message {  get; set; }
    public string Email { get; set; }
    public void OnGet(string email, string message)
    {
        Email = message;
        Message = message;
    }
}
