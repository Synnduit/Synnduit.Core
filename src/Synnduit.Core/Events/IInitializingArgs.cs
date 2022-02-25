namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when a subsystem is about to be
    /// initialized.
    /// </summary>
    public interface IInitializingArgs : IInitializationArgs
    {
        /// <summary>
        /// Gets the optional message (set by the subsystem that is being initialized); may
        /// be null.
        /// </summary>
        string Message { get; }
    }
}
