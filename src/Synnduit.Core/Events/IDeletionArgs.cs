namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for interfaces representing the event data for individual
    /// deletion-related events.
    /// </summary>
    public interface IDeletionArgs : IOperationArgs
    {
        /// <summary>
        /// Gets the ID that identifies the entity identified for deletion in the
        /// destination system.
        /// </summary>
        EntityIdentifier EntityId { get; }
    }
}
