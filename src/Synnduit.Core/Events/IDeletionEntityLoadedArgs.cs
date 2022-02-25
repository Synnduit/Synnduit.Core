namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when a destination system entity
    /// identified for deletion has been loaded from the destination system.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IDeletionEntityLoadedArgs<TEntity> : IDeletionArgs
    {
        /// <summary>
        /// Gets the entity (identified for deletion) as loaded from the destination
        /// system.
        /// </summary>
        TEntity Entity { get; }
    }
}
