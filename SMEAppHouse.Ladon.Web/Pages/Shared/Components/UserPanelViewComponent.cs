using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Infrastructure.Interfaces;
using SMEAppHouse.Ladon.Web.Areas.Identity.ViewModels;

namespace SMEAppHouse.Ladon.Web.Pages.Shared.Components;

public class UserPanelViewComponent : ViewComponent
{
    private readonly IAuthMembershipService _authService;
    private readonly ILogger<UserPanelViewComponent> _logger;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserPanelViewComponent(ILogger<UserPanelViewComponent> logger,
                            IAuthMembershipService authService, IHttpContextAccessor httpContextAccessor)
    {
        _authService = authService;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public async Task<IViewComponentResult> InvokeAsync(string labelledbyParam)
    {
        try
        {
            var userAuthenticationDetails = new UserAuthenticationDetails();
            var httpContext = _httpContextAccessor.HttpContext;

            if (httpContext?.User.Identity != null && 
                httpContext.User.Identity.IsAuthenticated)
            {
                // Retrieve the currently authenticated user
                UserProfileModel userProfileDto = null;
                if (httpContext != null)
                    userProfileDto = await _authService.GetUserAsync(httpContext.User);

                userAuthenticationDetails = new UserAuthenticationDetails
                {
                    IsAuthenticated = User.Identity?.IsAuthenticated ?? false,
                    UserName = User.Identity?.Name,
                    HasAdminRole = User.IsInRole("Admin"),
                    HasManagerRole = User.IsInRole("Manager"),
                    HasEditorRole = User.IsInRole("Editor"),
                    HasModeratorRole = User.IsInRole("Moderator"),
                    HasClientRole = User.IsInRole("Client"),
                    UserProfile = userProfileDto
                };
            }

            return View("Default", new { AuthDetails = userAuthenticationDetails, labelledbyParam });
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message, ex);
            throw;
        }
    }
}
