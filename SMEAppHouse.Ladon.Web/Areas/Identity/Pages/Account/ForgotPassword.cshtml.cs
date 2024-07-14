// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using SMEAppHouse.Ladon.Application.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using SMEAppHouse.Ladon.Web.Pages.Common;
using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class ForgotPasswordPageModel : BasePageModel
{
    private readonly ILogger<LoginPageModel> _logger;
    private readonly UserManager<IdentityUser<Guid>> _userManager;
    private readonly IEmailSender _emailSender;


    public ForgotPasswordPageModel(ILogger<LoginPageModel> logger,
                                    ApplicationSettings applicationSettings,
                                UserManager<IdentityUser<Guid>> userManager,
                                IEmailSender emailSender)
        : base(applicationSettings)
    {
        _logger = logger;
        _userManager = userManager;
        _emailSender = emailSender;
    }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    [BindProperty]
    public InputModel Input { get; set; }


    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var user = await _userManager.FindByEmailAsync(Input.Email);
        if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
        {
            // Don't reveal that the user does not exist or is not confirmed
            // Just return to the page
            return RedirectToPage("./ForgotPasswordConfirmation", new { email = Input.Email });
        }

        var code = await _userManager.GeneratePasswordResetTokenAsync(user);
        var codeEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var callbackUrl = Url.Action("ResetPassword", "Account", new { email = Input.Email, code = codeEncoded }, Request.Scheme);

        var emailRecipient = new Application.Models.EmailContact() { EmailAddress = Input.Email };
        var emailBody = $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.";

        await _emailSender.SendEmailAsync(
            base._applicationSettings.NoReplyEmailAddress,
            "Reset Password",
            emailBody,
            emailBody,
            [emailRecipient]);

        return RedirectToPage("./ForgotPasswordConfirmation", new { email = Input.Email });
    }
}
