namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when a source system entity is about to be
    /// processed.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IProcessingArgs<TEntity> : IOperationArgs
        where TEntity : class
    {
        /// <summary>
        /// Gets the (source system) entity that is about to be processed.
        /// </summary>
        TEntity Entity { get; }
    }
}
