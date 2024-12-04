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
        int? SegmentAbortThreshold { get; }

        /// <summary>
        /// Gets the number of exceptions that will trigger a run abort.
        /// </summary>
        int? RunAbortThreshold { get; }

        /// <summary>
        /// Gets the percentage of orphan mappings that will trigger an abort.
        /// </summary>
        double? OrphanMappingPercentageAbortThreshold { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the abort triggered by the
        /// <see cref="OrphanMappingPercentageAbortThreshold"/> should be applied to the entire
        /// run; if false or unset, the abort will only apply to the segment.
        /// </summary>
        bool? OrphanMappingPercentageThresholdAbortsRun { get; }

        /// <summary>
        /// Gets the percentage of entities identified for garbage collection that will trigger an
        /// abort.
        /// </summary>
        double? GarbageCollectionPercentageAbortThreshold { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the abort triggered by the
        /// <see cref="GarbageCollectionPercentageAbortThreshold"/> should be applied to the entire
        /// run; if false or unset, the abort will only apply to the segment.
        /// </summary>
        bool? GarbageCollectionPercentageThresholdAbortsRun { get; }
    }
}
