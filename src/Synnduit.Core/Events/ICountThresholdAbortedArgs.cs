namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for count threshold-based abort event data.
    /// </summary>
    public interface ICountThresholdAbortedArgs
    {
        /// <summary>
        /// Gets the number of exceptions that triggered the abort.
        /// </summary>
        int Threshold { get; }
    }
}
