namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when a garbage collection run segment has
    /// been initialized.
    /// </summary>
    public interface IGarbageCollectionInitializedArgs
    {
        /// <summary>
        /// Gets the number of entities to be deleted as part of the run segment.
        /// </summary>
        int Count { get; }
    }
}
