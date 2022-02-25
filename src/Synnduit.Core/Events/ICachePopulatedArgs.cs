namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when the (deduplication) in-memory cache
    /// of destination system entities has been populated.
    /// </summary>
    /// <seealso cref="Deduplication.ICache{TEntity}" />
    public interface ICachePopulatedArgs
    {
        /// <summary>
        /// Gets the number of entities cached.
        /// </summary>
        int Count { get; }
    }
}
