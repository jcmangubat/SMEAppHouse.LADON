using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Repositories;
using SMEAppHouse.Ladon.Infrastructure.Interfaces;

namespace SMEAppHouse.Ladon.Application.Services;

public class AuthMembershipService(IMapper mapper,
                            IUserProfileRepository userProfileRepository,
                            SignInManager<IdentityUser<Guid>> signInManager,
                            UserManager<IdentityUser<Guid>> userManager) : IAuthMembershipService
{
    private readonly SignInManager<IdentityUser<Guid>> _signInManager = signInManager;
    private readonly UserManager<IdentityUser<Guid>> _userManager = userManager;
    //private readonly UserManager<IdentityRole<Guid>> _roleManager;
    private readonly IUserStore<IdentityUser<Guid>> _userStore;
    private readonly IUserEmailStore<IdentityUser<Guid>> _emailStore;
    private readonly IUserProfileRepository _userProfileRepository = userProfileRepository;

    private readonly IMapper _mapper = mapper;

    public SignInManager<IdentityUser<Guid>> SignInManager => _signInManager;
    public UserManager<IdentityUser<Guid>> UserManager => _userManager;

    public IUserStore<IdentityUser<Guid>> UserStore => _userStore;
    public IUserEmailStore<IdentityUser<Guid>> EmailStore => _emailStore;

    public IdentityOptions Options => _userManager.Options;

    public bool SupportsUserEmail => _userManager.SupportsUserEmail;

    public async Task<IdentityResult> CreateAsync(IdentityUser<Guid> user, string password)
    {
        return await _userManager.CreateAsync(user, password);
    }

    public async Task<IdentityUser<Guid>?> FindByEmailAsync(string email)
    {
        return await _userManager.FindByEmailAsync(email);
    }

    public async Task<string> GenerateEmailConfirmationTokenAsync(IdentityUser<Guid> user)
    {
        return await _userManager.GenerateEmailConfirmationTokenAsync(user);
    }

    public async Task<UserProfileModel> GetUserAsync(ClaimsPrincipal user)
    {
        if (!user.Identity.IsAuthenticated)
            return null;

        var claimsUsr = await _userManager.GetUserAsync(user);
        if (claimsUsr == null)
            return null;

        var userProfile = await _userProfileRepository.GetSingleAsync(p => p.IdentityUserId == claimsUsr.Id);
        if (userProfile == null)
            return null;

        var usrDto = _mapper.Map<UserProfileModel>(userProfile);
        return usrDto;
    }

    public async Task<string> GetUserIdAsync(IdentityUser<Guid> user)
    {
        return await _userManager.GetUserIdAsync(user);
    }

    public async Task<SignInResult> PasswordSignInAsync(string email, string password, bool rememberMe, bool lockoutOnFailure)
    {
        return await _signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: lockoutOnFailure);
    }

    public async Task SignInAsync(IdentityUser<Guid> user, bool? isPersistent = false)
    {
        await _signInManager.SignInAsync(user, isPersistent: isPersistent ?? false);
    }

    public async Task SignOutAsync()
    {
        await _signInManager.SignOutAsync();
    }
}