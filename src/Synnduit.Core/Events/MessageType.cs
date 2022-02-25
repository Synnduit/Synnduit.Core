namespace Synnduit.Events
{
    /// <summary>
    /// Represents individual log message types.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Error.
        /// </summary>
        Error = 1,

        /// <summary>
        /// Warning.
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Exception.
        /// </summary>
        Exception = 3,

        /// <summary>
        /// Informational message.
        /// </summary>
        Information = 4
    }
}
