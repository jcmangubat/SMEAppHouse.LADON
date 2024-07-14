using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Infrastructure.Interfaces;

public interface IAuthMembershipService
{
    SignInManager<IdentityUser<Guid>> SignInManager { get; }
    UserManager<IdentityUser<Guid>> UserManager { get; }
    IUserStore<IdentityUser<Guid>> UserStore { get; }
    IUserEmailStore<IdentityUser<Guid>> EmailStore { get; }
    IdentityOptions Options { get; }
    bool SupportsUserEmail { get; }

    Task<IdentityResult> CreateAsync(IdentityUser<Guid> user, string password);
    Task<IdentityUser<Guid>?> FindByEmailAsync(string email);
    Task<string> GenerateEmailConfirmationTokenAsync(IdentityUser<Guid> user);
    Task<UserProfileModel> GetUserAsync(ClaimsPrincipal user);
    Task<string> GetUserIdAsync(IdentityUser<Guid> user);
    Task<SignInResult> PasswordSignInAsync(string email, string password, bool rememberMe, bool lockoutOnFailure);
    Task SignInAsync(IdentityUser<Guid> user, bool? isPersistent = false);
    Task SignOutAsync();
}
