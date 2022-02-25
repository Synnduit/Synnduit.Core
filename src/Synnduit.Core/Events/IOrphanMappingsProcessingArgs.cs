namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when orphan identifier mappings are about
    /// to be processed.
    /// </summary>
    public interface IOrphanMappingsProcessingArgs
    {
        /// <summary>
        /// Gets the number of orphan mappings to process.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the orphan mapping behavior that is being applied.
        /// </summary>
        OrphanMappingBehavior Behavior { get; }
    }
}
