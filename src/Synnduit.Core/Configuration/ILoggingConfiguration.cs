namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the application's logging behavior configuration.
    /// </summary>
    public interface ILoggingConfiguration
    {
        /// <summary>
        /// Gets the application's migration logging behavior configuration.
        /// </summary>
        IMigrationLoggingConfiguration Migration { get; }

        /// <summary>
        /// Gets the application's garbage collection logging behavior configuration.
        /// </summary>
        IGarbageCollectionLoggingConfiguration GarbageCollection { get; }
    }
}
