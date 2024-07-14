using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;
using System.Text;


namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public class ConfirmEmailPageModel(ILogger<ConfirmEmailPageModel> logger,
                                    ApplicationSettings applicationSettings,
                                    UserManager<IdentityUser<Guid>> userManager)
                                    : BasePageModel(applicationSettings)
{
    private readonly ILogger<ConfirmEmailPageModel> _logger = logger;
    private readonly UserManager<IdentityUser<Guid>> _userManager = userManager;

    [TempData]
    public string StatusMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(string userId, string code)
    {
        if (userId == null || code == null)
            return RedirectToPage("/Index");

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            //return NotFound($"Unable to load user with ID '{userId}'.");

            StatusMessage = "Error confirming your email.";
            return Page();
        }

        if (user.EmailConfirmed)
        {
            StatusMessage = "Your email has already been confirmed. Thank you for joining us!";
            StatusMessage += "You can now <a href=\"/Account/Login\"><b>sign in</b></a>.";
            return Page();
        }

        code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
        var result = await _userManager.ConfirmEmailAsync(user, code);

        if (result.Succeeded)
        {
            StatusMessage = "Thank you for confirming your email.";
        }
        else
        {
            if (result.Errors.Any(e => e.Code == "InvalidToken"))
                StatusMessage = "Error confirming your email. The confirmation link may have expired already.";
            else
                StatusMessage = "Error confirming your email.";
        }

        return Page();
    }
}