namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for interfaces representing the event data for individual
    /// abort events.
    /// </summary>
    public interface IAbortedArgs
    {
        /// <summary>
        /// Gets the number of exceptions that triggered the abort.
        /// </summary>
        int Threshold { get; }
    }
}
