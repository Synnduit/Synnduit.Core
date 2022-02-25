namespace Synnduit.Events
{
    /// <summary>
    /// To be implemented by individual event receivers; i.e., classes subscribing to the
    /// event represented by the event data generic type.
    /// </summary>
    /// <typeparam name="TEventArgs">The type representing the event data.</typeparam>
    public interface IEventReceiver<TEventArgs>
    {
        /// <summary>
        /// Called when the event represented by the current instance occurs.
        /// </summary>
        /// <param name="args">The event data.</param>
        void Occurred(TEventArgs args);
    }
}
