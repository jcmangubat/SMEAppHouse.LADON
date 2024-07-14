// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.Infrastructure.Interfaces;
using SMEAppHouse.Ladon.Web.Areas.Identity.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class LoginPageModel : PageModel
{
    private readonly SignInManager<IdentityUser<Guid>> _signInManager;
    private readonly IAuthMembershipService _authService;
    private readonly ILogger<LoginPageModel> _logger;

    public LoginPageModel(ILogger<LoginPageModel> logger, 
                                SignInManager<IdentityUser<Guid>> signInManager,
                                IAuthMembershipService authService)
    {
        _logger = logger;
        _signInManager = signInManager;
        _authService = authService;        
    }

    [BindProperty]
    public LoginInputModel Input { get; set; }

    [TempData]
    public string ErrorMessage { get; set; }

    public string ReturnUrl { get; set; }

    public IList<AuthenticationScheme> ExternalLogins { get; set; }

    public async Task OnGetAsync(string returnUrl = null)
    {
        if (!string.IsNullOrEmpty(ErrorMessage))
        {
            ModelState.AddModelError(string.Empty, ErrorMessage);
        }

        returnUrl ??= Url.Content("~/");

        // Clear the existing external cookie to ensure a clean login process
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
        await _signInManager.SignOutAsync();

        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        ReturnUrl = returnUrl;
    }

    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        if (!ModelState.IsValid)
            return Page();

        try
        {
            var result = await _authService.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }

            // If RememberMe is checked, set the expiration time for the cookie to a longer period
            var expires = Input.RememberMe ? DateTime.UtcNow.AddDays(7) : DateTime.UtcNow.AddHours(1);

            // Create a claims identity for the authenticated user
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, Input.Email),
                new(ClaimTypes.Email, Input.Email)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            // Create the authentication properties
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = expires,
                IsPersistent = Input.RememberMe
            };

            // Sign in the user with the claims identity and authentication properties
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            _logger.LogInformation(message: $"User {Input.Email} has successfully logged in.");

            // Check if returnUrl is for the login page itself or for external site
            if (!Url.IsLocalUrl(returnUrl))
                return Redirect("/");

            return LocalRedirect(returnUrl);
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message, ex);
            throw;
        }
    }
}
