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

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class LoginModel(ILogger<LoginModel> logger, IAuthMembershipService authService) : PageModel
{
    private readonly IAuthMembershipService _authService = authService;
    private readonly ILogger<LoginModel> _logger = logger;

    [BindProperty]
    public LoginInputModel Input { get; set; }

    public string ReturnUrl { get; set; }

    public void OnGet(string returnUrl = null)
    {
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

            //var aspNetUserDto = _userManager.UserManager.get

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
