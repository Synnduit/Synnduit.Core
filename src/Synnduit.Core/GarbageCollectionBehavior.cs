namespace Synnduit
{
    /// <summary>
    /// Defines individual garbage collection behaviors.
    /// </summary>
    public enum GarbageCollectionBehavior
    {
        /// <summary>
        /// Only unreferenced entities created by the current system instance will be
        /// deleted.
        /// </summary>
        DeleteCreated = 1,

        /// <summary>
        /// Unreferenced entities that at least one identifier mapping exists for (whether
        /// obtained through creation or deduplication) will be deleted.
        /// </summary>
        DeleteMapped,

        /// <summary>
        /// All unreferenced entities will be deleted.
        /// </summary>
        DeleteAll
    }
}
