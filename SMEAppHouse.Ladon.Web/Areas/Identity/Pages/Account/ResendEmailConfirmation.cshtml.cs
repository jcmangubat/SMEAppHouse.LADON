using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;
using System.Text;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class ResendEmailConfirmationPageModel(
                                    ApplicationSettings settings,
                                    ILogger<LoginPageModel> logger,
                                    UserManager<IdentityUser<Guid>> userManager,
                                    IEmailSender emailSender) : BasePageModel(settings)
{
    private readonly ILogger<LoginPageModel> _logger = logger;
    private readonly UserManager<IdentityUser<Guid>> _userManager = userManager;
    private readonly IEmailSender _emailSender = emailSender;

    [BindProperty]
    public string Email { get; set; }

    public string GivenName { get; set; }
    public string ProviderDisplayName { get; set; }

    public void OnGet()
    {
        // Retrieve Email, GivenName, and ProviderDisplayName from query parameters or session
        // This is just a placeholder, update according to how you pass these values
        Email = HttpContext.Request.Query["email"];
        GivenName = HttpContext.Request.Query["givenName"];
        ProviderDisplayName = HttpContext.Request.Query["providerDisplayName"];
    }

    public async Task<IActionResult> OnPostSendEmailConfirmationAsync(string email, string givenName, string providerDisplayName)
    {
        if (string.IsNullOrEmpty(email))
        {
            ModelState.AddModelError(string.Empty, "Email address is required.");
            return Page();
        }

        var user = await _userManager.FindByEmailAsync(email);
        string message;

        if (user == null)
        {
            message = "No user exist associated with the email address.";
            ModelState.AddModelError(string.Empty, message);
            return RedirectToPage("./ResendEmailConfirmationConfirm", new { email, message });
        }

        if (await _userManager.IsEmailConfirmedAsync(user))
        {
            message = "No need to resend confirmation. Email account is already confirmed.";
            ModelState.AddModelError(string.Empty, message);
            return RedirectToPage("./ResendEmailConfirmationConfirm", new { email, message });
        }

        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var codeEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = codeEncoded }, Request.Scheme);

        message = $"Please confirm your email by clicking <a href='{confirmationLink}'>here</a>.";

        var emailRecipient = new EmailContact() { EmailAddress = email };
        await _emailSender.SendEmailAsync(base._applicationSettings.NoReplyEmailAddress,
                                            "Confirm your email", message, message,
                                            [emailRecipient]);

        message = $"If an account with the provided email address exists and is not yet confirmed, a confirmation email has been sent. Please click the link sent to your email address, <b>{email}</b>, to confirm your account.";
        return RedirectToPage("./ResendEmailConfirmationConfirm", new { email, message });
    }
}

