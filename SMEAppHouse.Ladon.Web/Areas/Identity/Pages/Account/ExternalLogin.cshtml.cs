using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

[AllowAnonymous]
public class ExternalLoginPageModel : BasePageModel
{
    private readonly ILogger<ExternalLoginPageModel> _logger;
    private readonly SignInManager<IdentityUser<Guid>> _signInManager;
    private readonly UserManager<IdentityUser<Guid>> _userManager;
    private readonly IUserStore<IdentityUser<Guid>> _userStore;
    private readonly IUserEmailStore<IdentityUser<Guid>> _emailStore;
    private readonly IEmailSender _emailSender;
    private readonly IUserProfileService _userProfileService;

    public ExternalLoginPageModel(
        ILogger<ExternalLoginPageModel> logger,
        ApplicationSettings applicationSettings,
        SignInManager<IdentityUser<Guid>> signInManager,
        UserManager<IdentityUser<Guid>> userManager,
        IUserStore<IdentityUser<Guid>> userStore,
        IUserProfileService userProfileService,
        IEmailSender emailSender)
        : base(applicationSettings)
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
        _userStore = userStore;
        _emailStore = GetEmailStore();
        _emailSender = emailSender;
        _userProfileService = userProfileService;
    }

    public string ReturnUrl { get; set; }
    public string ProviderDisplayName { get; set; }
    public string GivenName { get; set; }
    [TempData]
    public string ErrorMessage { get; set; }

    public string Email { get; set; }
    public bool CanResendEmail { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
        CanResendEmail = !string.IsNullOrEmpty(Email);
    }

    public IActionResult OnPost(string provider, string? returnUrl = null)
    {
        // Request a redirect to the external login provider.
        var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });
        var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        return new ChallengeResult(provider, properties);
    }

    public async Task<IActionResult> OnGetCallbackAsync(string? returnUrl = null, string? remoteError = null)
    {
        returnUrl ??= Url.Content("~/");

        if (remoteError != null)
        {
            ErrorMessage = $"Error from external provider: {remoteError}";
            return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
        }

        var info = await _signInManager.GetExternalLoginInfoAsync();
        if (info == null)
        {
            ErrorMessage = "Error loading external login information.";
            _logger.LogWarning("External login info is null");
            return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
        }

        _logger.LogInformation("External login info: {LoginProvider}, {ProviderKey}", info.LoginProvider, info.ProviderKey);

        // Sign in the user with this external login provider if the user already has a login.
        var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
        if (result.Succeeded)
        {
            _logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
            return LocalRedirect(returnUrl);
        }

        if (result.IsLockedOut)
        {
            _logger.LogWarning("User account locked out.");
            return RedirectToPage("./Lockout");
        }

        if (result.RequiresTwoFactor)
        {
            _logger.LogInformation("Two-factor authentication required.");
            return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = false });
        }

        // At this point, we need to either create a new user or handle existing user issues.
        IdentityUser<Guid>? user = null;

        if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
        {
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            user = await _userManager.FindByEmailAsync(email ?? string.Empty);

            if (user != null)
            {
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    _logger.LogWarning("User email not confirmed.");
                    GivenName = info.Principal.FindFirstValue(ClaimTypes.GivenName) ?? string.Empty;
                    ReturnUrl = returnUrl;
                    ProviderDisplayName = info.ProviderDisplayName;
                    CanResendEmail = !string.IsNullOrEmpty(email);
                    Email = email;
                    Message = string.Empty;
                    return Page();
                }
            }
        }

        if (user == null)
        {
            user = CreateUser();
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            await _userStore.SetUserNameAsync(user, email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, email, CancellationToken.None);

            var identResult = await _userManager.CreateAsync(user);
            if (identResult.Succeeded)
            {
                identResult = await _userManager.AddLoginAsync(user, info);
                if (identResult.Succeeded)
                {
                    _logger.LogInformation("User created an account using {LoginProvider} provider.", info.LoginProvider);

                    var userId = await _userManager.GetUserIdAsync(user);
                    await CreateUserProfile(userId, info);

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var codeEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    var callbackUrl = Url.Action(
                        action: "ConfirmEmail",
                        controller: "Account",
                        values: new { userId, code = codeEncoded },
                        protocol: Request.Scheme);

                    await SendEmailConfirmationAsync(email, callbackUrl);

                    //return RedirectToPage("./EmailConfirmation", new { Email = email });

                    ReturnUrl = returnUrl;
                    GivenName = info.Principal.FindFirstValue(ClaimTypes.GivenName) ?? string.Empty;
                    ProviderDisplayName = info.ProviderDisplayName ?? string.Empty;
                    CanResendEmail = !string.IsNullOrEmpty(email);
                    Email = email;
                    Message = $"Thank you {GivenName}, for siging up!";
                    return Page();
                }
            }

            foreach (var error in identResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        ReturnUrl = returnUrl;
        ProviderDisplayName = info.ProviderDisplayName;

        /*// If we reach here, it means we need to prompt the user to complete registration.
        ReturnUrl = returnUrl;
        ProviderDisplayName = info.ProviderDisplayName;
        if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
        {
            Input = new InputModel
            {
                Email = info.Principal.FindFirstValue(ClaimTypes.Email)
            };
        }*/

        return Page();
    }

    private async Task CreateUserProfile(string userId, ExternalLoginInfo info)
    {
        var firstName = info.Principal.FindFirstValue(ClaimTypes.GivenName);
        var lastName = info.Principal.FindFirstValue(ClaimTypes.Surname);
        var gender = info.Principal.FindFirstValue(ClaimTypes.Gender);
        var ourGender = string.IsNullOrEmpty(gender) ?
                            GendersEnum.Other :
                            gender.ToLower().Equals("male") ?
                            GendersEnum.Male : GendersEnum.Female;
        var thumbNailUrl = ourGender == GendersEnum.Other ?
                            "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Assets/Avatars/anon-user-1.png" :
                            ourGender == GendersEnum.Male
                                ? "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Assets/Avatars/anon-male-1.png"
                                : "https://ik.imagekit.io/yt1tgrjzh/LADONCO/Assets/Avatars/anon-female-1.png";
        var mobilePhoneNo = info.Principal.FindFirstValue(ClaimTypes.MobilePhone);

        var usrProfile = new UserProfileModel
        {
            Id = Guid.NewGuid(),
            IdentityUserId = Guid.Parse(userId),
            FirstName = firstName ?? string.Empty,
            LastName = lastName ?? string.Empty,
            Gender = ourGender,
            ClientCode = null,
            ThumbnailUrl = thumbNailUrl,
            MobilePhoneNo = mobilePhoneNo ?? string.Empty,
        };
        await _userProfileService.AddUserProfileAsync(usrProfile);
    }

    private async Task SendEmailConfirmationAsync(string emailAddress, string callbackUrl)
    {
        await _emailSender.SendEmailAsync(base._applicationSettings.NoReplyEmailAddress,
            "Confirm your email",
            $"Please confirm your account by clicking here: {callbackUrl}",
             $"<p>Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here.</a></p>",
             [new EmailContact() { EmailAddress = emailAddress }],
             null, null
            );
    }

    public async Task<IActionResult> OnPostSendEmailConfirmationAsync(string email, string givenName, string providerDisplayName)
    {
        if (string.IsNullOrEmpty(email))
            return RedirectToPage("./Login");

        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            return RedirectToPage("./Login");

        var userId = await _userManager.GetUserIdAsync(user);
        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var codeEncoded = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

        var callbackUrl = Url.Action(
            action: "ConfirmEmail",
            controller: "Account",
            values: new { userId, code = codeEncoded },
            protocol: Request.Scheme);

        await _emailSender.SendEmailAsync(base._applicationSettings.NoReplyEmailAddress,
            "Confirm your email",
            $"Please confirm your account by clicking here: {callbackUrl}",
             $"<p>Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here.</a></p>",
             [new EmailContact() { EmailAddress = email }],
             null, null
            );

        //ReturnUrl = returnUrl;
        GivenName = givenName;
        ProviderDisplayName = providerDisplayName;
        CanResendEmail = !string.IsNullOrEmpty(email);
        Email = email;
        Message = "Confirmation email has been resent to you.";
        return Page();
    }

    private IdentityUser<Guid> CreateUser()
    {
        try
        {
            return Activator.CreateInstance<IdentityUser<Guid>>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                $"override the external login page in /Areas/Identity/Pages/Account/ExternalLogin.cshtml");
        }
    }

    private IUserEmailStore<IdentityUser<Guid>> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail)
            throw new NotSupportedException("The default UI requires a user store with email support.");

        return (IUserEmailStore<IdentityUser<Guid>>)_userStore;
    }
}
