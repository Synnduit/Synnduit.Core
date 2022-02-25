namespace Synnduit
{
    /// <summary>
    /// Represents individual run segment types.
    /// </summary>
    public enum SegmentType
    {
        /// <summary>
        /// The migration of entities of a type from a source system into a destination
        /// system.
        /// </summary>
        Migration = 1,

        /// <summary>
        /// The garbage collection of entities in a destination system (i.e., the deletion
        /// of those that no longer exist in any source system).
        /// </summary>
        GarbageCollection = 2
    }
}
