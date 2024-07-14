using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class ResetPasswordPageModel : BasePageModel
{
    private readonly UserManager<IdentityUser<Guid>> _userManager;

    public ResetPasswordPageModel(ApplicationSettings applicationSettings,
        UserManager<IdentityUser<Guid>> userManager)
        : base(applicationSettings)
    {
        _userManager = userManager;
        PasswordOptions = _userManager.Options.Password;
    }

    public PasswordOptions PasswordOptions { get; private set; }

    [BindProperty]
    public InputModel Input { get; set; } = new InputModel();

    [BindProperty]
    public string Email { get; set; }  // Added Email property for form binding
    [BindProperty]
    public string Code { get; set; }  // Added Code property for form binding

    public class InputModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public async Task<IActionResult> OnGetAsync(string email, string code)
    {
        if (email == null || code == null)
            return RedirectToPage("/Index");
        
        Email = email;
        Code = code;

        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            return NotFound($"Unable to load user with email '{email}'.");
        
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string email, string code)
    {
        if (!ModelState.IsValid)
            return Page();
        
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            return NotFound($"Unable to load user with email '{email}'.");

        var decodedCode = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
        var result = await _userManager.ResetPasswordAsync(user, decodedCode, Input.Password);
        if (result.Succeeded)
            return RedirectToPage("./ResetPasswordConfirmation");

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return Page();
    }
}
