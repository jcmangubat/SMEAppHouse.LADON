using Serilog;
using SMEAppHouse.Core.CodeKits.Helpers;

namespace SMEAppHouse.Ladon.Web.Middleware;

public class ErrorLoggingMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            var errorMsg = $"==> {nameof(ErrorLoggingMiddleware)} : An unhandled exception occurred while processing the request. : {ex.GetExceptionMessages()}";
            Log.Error(ex, errorMsg);
            Console.WriteLine(errorMsg);
            throw; // Re-throw the exception to ensure it's propagated to the next error handling middleware or the hosting environment.
        }
    }
}
