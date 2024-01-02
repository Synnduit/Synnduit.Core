namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the application's exception handling behavior configuration.
    /// </summary>
    public interface IExceptionHandlingConfiguration
    {
        /// <summary>
        /// Gets the number of exceptions that will trigger a segment abort.
        /// </summary>
        int? PerSegmentAbortThreshold { get; }

        /// <summary>
        /// Gets the number of exceptions that will trigger a run abort.
        /// </summary>
        int? PerRunAbortThreshold { get; }
    }
}
