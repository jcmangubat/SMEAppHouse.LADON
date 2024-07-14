using SMEAppHouse.Ladon.Web.Middleware;
using SMEDigital.Ladon.Web.Middlewares;

namespace SMEAppHouse.Ladon.Web.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseErrorLoggingMiddleware(this IApplicationBuilder builder) =>
        builder.UseMiddleware<ErrorLoggingMiddleware>();

    public static IApplicationBuilder UseCSRFAntiforgeryTokenMiddleware(this IApplicationBuilder builder) =>
        builder.UseMiddleware<CSRFAntiforgeryTokenMiddleware>();
}