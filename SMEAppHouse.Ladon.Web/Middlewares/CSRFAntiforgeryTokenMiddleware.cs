using Microsoft.AspNetCore.Antiforgery;
using Serilog;
using SMEAppHouse.Core.CodeKits.Helpers;

namespace SMEDigital.Ladon.Web.Middlewares;

public class CSRFAntiforgeryTokenMiddleware
{
    private readonly RequestDelegate _next;

    public CSRFAntiforgeryTokenMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IAntiforgery antiforgery)
    {
        try
        {
            if (context.Request.Path == "/")
            {
                var tokens = antiforgery.GetAndStoreTokens(context);
                context.Response.Cookies.Append("X-CSRF-TOKEN", tokens.RequestToken,
                    new CookieOptions
                    {
                        HttpOnly = false,
                        IsEssential = true,
                        SameSite = SameSiteMode.Strict,
                        Secure = true
                    });

                if (!context.Response.Headers.ContainsKey("X-CSRF-TOKEN"))
                    context.Response.Headers.Add("X-CSRF-TOKEN", tokens.RequestToken);
            }

            await _next(context);
        }
        catch (Exception ex)
        {
            Log.Error(ex, $"==> {nameof(CSRFAntiforgeryTokenMiddleware)} : An unhandled exception occurred while processing the request. : {ex.GetExceptionMessages()}");
            throw; // Re-throw the exception to ensure it's propagated to the next error handling middleware or the hosting environment.
        }
    }
}