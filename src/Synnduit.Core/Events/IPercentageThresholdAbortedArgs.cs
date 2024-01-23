namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for percentage threshold-based abort event data.
    /// </summary>
    public interface IPercentageThresholdAbortedArgs
    {
        /// <summary>
        /// Gets the percentage that will trigger an abort.
        /// </summary>
        double Threshold { get; }

        /// <summary>
        /// Gets the percentage actually identified.
        /// </summary>
        double Percentage { get; }
    }
}
