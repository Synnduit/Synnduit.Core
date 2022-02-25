namespace Synnduit.Events
{
    /// <summary>
    /// The interface to be implemented by individual event receivers.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    /// <remarks>
    /// This interface exists for dependency injection purposes only, and it doesn't expose
    /// any methods or properties. It allows event receiver implementers to express what
    /// entity type (or types) their event receivers should apply to.
    /// Always implement the <see cref="IEventReceiver{TEventArgs}" /> interface for any
    /// events you wish to receive.
    /// </remarks>
    public interface IEntityTypeEventReceiver<TEntity>
        where TEntity : class
    {
    }
}
