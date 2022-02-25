namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when source/destination system identifier
    /// mappings have been loaded from the database into the in-memory cache.
    /// </summary>
    public interface IMappingsCachedArgs
    {
        /// <summary>
        /// Gets the number of mappings loaded and cached.
        /// </summary>
        int Count { get; }
    }
}
