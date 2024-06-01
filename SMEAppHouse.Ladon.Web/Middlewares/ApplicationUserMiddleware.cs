using SMEAppHouse.Ladon.Infrastructure.Interfaces;

namespace SMEAppHouse.Ladon.Web.Middleware;

public class ApplicationUserMiddleware
{
    private readonly IAuthMembershipService _authService;
    private readonly RequestDelegate _next;

    public ApplicationUserMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IAuthMembershipService userManager)
    {
        if (context.User.Identity.IsAuthenticated)
        {
            // Get the current authenticated user
            var user = await userManager.GetUserAsync(context.User);

            if (user != null)
            {
                // Use the user object as needed
                string firstName = user.FirstName;
                string lastName = user.LastName;
                // Access other properties or perform operations
            }
            else
            {
                // User not found or not authenticated
                // Handle accordingly
            }
        }

        // Call the next middleware in the pipeline
        await _next(context);
    }
}
