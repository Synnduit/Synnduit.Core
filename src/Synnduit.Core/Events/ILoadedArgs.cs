namespace Synnduit.Events
{
    /// <summary>
    /// The event data for the event that occurs when entities from a source system have
    /// been loaded.
    /// </summary>
    public interface ILoadedArgs
    {
        /// <summary>
        /// Gets the number of entities loaded.
        /// </summary>
        int Count { get; }
    }
}
