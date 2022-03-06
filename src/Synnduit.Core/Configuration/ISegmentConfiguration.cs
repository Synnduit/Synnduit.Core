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
    }
}
