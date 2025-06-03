using Microsoft.Extensions.Logging;

internal static partial class DataMessageLogger
{
    [LoggerMessage(Message = "Could not deserialize DomainEventReference {Id}")]
    public static partial void CouldNotDeserializeDomainEvent(this ILogger logger, LogLevel level, Guid Id);
}