using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace SMEAppHouse.Ladon.Infrastructure.Helpers
{
    public static class LoggerUtility
    {
        public static void LogInformation(this ILogger logger, string message, [CallerMemberName] string methodName = "")
        {
            logger.LogInformation("{MethodName}: {Message}", methodName, message);
        }

        public static void LogWarning(this ILogger logger, string message, [CallerMemberName] string methodName = "")
        {
            logger.LogWarning("{MethodName}: {Message}", methodName, message);
        }

        public static void LogError(this ILogger logger, string message, [CallerMemberName] string methodName = "")
        {
            logger.LogError("{MethodName}: {Message}", methodName, message);
        }

        public static void LogDebug(this ILogger logger, string message, [CallerMemberName] string methodName = "")
        {
            logger.LogDebug("{MethodName}: {Message}", methodName, message);
        }
    }
}
