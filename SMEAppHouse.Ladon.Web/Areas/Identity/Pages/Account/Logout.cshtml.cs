// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.Infrastructure.Interfaces;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account
{
    public class LogoutModel(IAuthMembershipService userManager, ILogger<LogoutModel> logger)
        : PageModel
    {
        private readonly IAuthMembershipService _authService = userManager;
        private readonly ILogger<LogoutModel> _logger = logger;

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _authService.SignOutAsync();
            _logger.LogInformation("User logged out.");
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                // This needs to be a redirect so that the browser performs a new
                // request and the identity for the user gets updated.
                return RedirectToPage("/Index");
            }
        }

        public IActionResult OnPostLogout()
        {
            // Perform logout actions here

            // Redirect to the root page
            return RedirectToPage("/");
        }
    }
}
