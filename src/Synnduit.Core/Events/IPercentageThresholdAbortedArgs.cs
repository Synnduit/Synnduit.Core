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

        /// <summary>
        /// Gets a value indicating whether the entire run is being aborted; if false, the abort
        /// only applies to the current segment.
        /// </summary>
        bool RunAborted { get; }
    }
}
