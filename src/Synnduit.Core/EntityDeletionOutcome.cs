namespace Synnduit
{
    /// <summary>
    /// Represents possible outcomes of an attempt to delete a destination system entity.
    /// </summary>
    public enum EntityDeletionOutcome
    {
        /// <summary>
        /// The entity was deleted successfully.
        /// </summary>
        Deleted = 1,

        /// <summary>
        /// The entity, while identified by the garbage collection process as one that
        /// should be deleted, could not be found (in the destination system).
        /// </summary>
        NotFound = 2,

        /// <summary>
        /// An exception was thrown while the attempt to delete the entity was being made.
        /// </summary>
        ExceptionThrown = 3
    }
}
