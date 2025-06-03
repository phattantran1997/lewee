using Microsoft.Extensions.Logging;

namespace Lewee.Infrastructure.AspNet.SignalR;

internal static partial class SignalRMessageLogger
{
    [LoggerMessage(Level = LogLevel.Debug, Message = "Published message to all clients")]
    public static partial void LogPublishedToAllClients(this ILogger logger);

    [LoggerMessage(Level = LogLevel.Debug, Message = "Published message to specific client(s)")]
    public static partial void LogPublishedToSpecificClients(this ILogger logger);

    [LoggerMessage(Level = LogLevel.Debug, Message = "Client connected")]
    public static partial void LogClientConnected(this ILogger logger);

    [LoggerMessage(Level = LogLevel.Debug, Message = "Client added to SignalR group")]
    public static partial void LogClientAddedToGroup(this ILogger logger);
}
