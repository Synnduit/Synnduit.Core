namespace Synnduit.Events
{
    /// <summary>
    /// Logs messages associated with the operation that is being processed at a given
    /// time.
    /// </summary>
    public interface IMessageLogger
    {
        /// <summary>
        /// Logs a message associated with the operation that is currently being processed.
        /// </summary>
        /// <param name="type">The message type.</param>
        /// <param name="message">The message text.</param>
        void Log(MessageType type, string message);
    }
}
