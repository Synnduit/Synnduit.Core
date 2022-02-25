namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when the deletion of a destination system
    /// entity (identified for deletion) has been processed.
    /// </summary>
    public interface IDeletionProcessedArgs : IOperationCompletedArgs, IDeletionArgs
    {
        /// <summary>
        /// Gets the outcome of the deletion.
        /// </summary>
        EntityDeletionOutcome Outcome { get; }
    }
}
