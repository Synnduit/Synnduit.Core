namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the configuration of a single run segment.
    /// </summary>
    public interface ISegmentConfiguration : IConfigurationBase
    {
        /// <summary>
        /// Gets the segment type.
        /// </summary>
        SegmentType Type { get; }

        /// <summary>
        /// Gets the entity type.
        /// </summary>
        string EntityType { get; }

        /// <summary>
        /// Gets the number of exceptions that will trigger an abort; this overrides the global
        /// <see cref="IExceptionHandlingConfiguration.SegmentAbortThreshold"/> value.
        /// </summary>
        int? SegmentAbortThreshold { get; }

        /// <summary>
        /// Gets the percentage of orphan mappings that will trigger an abort; this overrides the
        /// global
        /// <see cref="IExceptionHandlingConfiguration.OrphanMappingPercentageAbortThreshold"/>
        /// value.
        /// </summary>
        double? OrphanMappingPercentageAbortThreshold { get; }

        /// <summary>
        /// Gets the percentage of entities identified for garbage collection that will trigger an
        /// abort; this overrides the global
        /// <see cref="IExceptionHandlingConfiguration.GarbageCollectionPercentageAbortThreshold"/>
        /// value.
        /// </summary>
        double? GarbageCollectionPercentageAbortThreshold { get; }
    }
}
