namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when a subsystem has been initialized.
    /// </summary>
    public interface IInitializedArgs : IInitializationArgs
    {
        /// <summary>
        /// Gets the optional pre-initialization message (set by the subsystem that is
        /// being initialized); may be null.
        /// </summary>
        /// <remarks>
        /// This property will have the same value as
        /// <see cref="IInitializingArgs.Message" />.
        /// </remarks>
        string InitializingMessage { get; }

        /// <summary>
        /// Gets the optional post-initialization message (set by the subsystem that is
        /// being initialized); may be null.
        /// </summary>
        string Message { get; }
    }
}
