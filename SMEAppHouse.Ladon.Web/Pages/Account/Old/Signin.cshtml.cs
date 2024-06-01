using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.DataAccess.EntityModels;
using SMEAppHouse.Ladon.Web.Pages.Account.ViewModels;

namespace SMEAppHouse.Ladon.Web.Pages.Account;

public partial class SigninModel(ILogger<IndexModel> logger,
                    SignInManager<ApplicationUser> signInManager,
                    UserManager<ApplicationUser> userManager) : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    [BindProperty]
    public LoginInputModel Input { get; set; }

    public string ReturnUrl { get; set; }

    public void OnGet(string returnUrl = null)
    {
        ReturnUrl = returnUrl;
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        if (!ModelState.IsValid)
            return Page();

        var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
        if (!result.Succeeded)
        {
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

        // Check if returnUrl is for the login page itself or for external site
        if (!Url.IsLocalUrl(returnUrl))
            return Redirect("/");

        return LocalRedirect(returnUrl);
    }
}
