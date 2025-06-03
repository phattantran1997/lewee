using Microsoft.Extensions.Logging;

namespace Lewee.Blazor.Logging;

internal static partial class BlazorMessageLogger
{

    [LoggerMessage(Level = LogLevel.Debug, Message = "Checking server health {ServerBaseAddress}")]
    public static partial void LogCheckingServerHealthWithAddress(this ILogger logger, string ServerBaseAddress);

    [LoggerMessage(Message = "Failed health check")]
    public static partial void LogHealthCheckFailed(this ILogger logger, LogLevel level, Exception ex);
}
