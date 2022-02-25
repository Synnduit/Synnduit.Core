namespace Synnduit.Events
{
    /// <summary>
    /// Represents a log message.
    /// </summary>
    public interface ILogMessage
    {
        /// <summary>
        /// Gets the message type.
        /// </summary>
        MessageType Type { get; }

        /// <summary>
        /// Gets the message text.
        /// </summary>
        string Message { get; }
    }
}
