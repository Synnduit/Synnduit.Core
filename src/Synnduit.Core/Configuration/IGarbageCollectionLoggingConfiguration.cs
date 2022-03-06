namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the application's garbage collection logging behavior configuration.
    /// </summary>
    public interface IGarbageCollectionLoggingConfiguration
    {
        /// <summary>
        /// Gets a comma-separated list of <see cref="EntityDeletionOutcome" /> values identifying
        /// entity deletions that should be excluded from logging; the default is null (i.e., all
        /// entity deletions are logged by default).
        /// </summary>
        string ExcludedOutcomes { get; }

        /// <summary>
        /// Gets a value indicating whether the destination system entity that is being deleted
        /// should be recorded in the log; the default is true.
        /// </summary>
        bool Entity { get; }

        /// <summary>
        /// Gets a value indicating whether an entity deletion should always be logged if there is
        /// at least one message associated with it, (possibly) effectively overriding the
        /// <see cref="ExcludedOutcomes" /> values; the default is false.
        /// </summary>
        bool AlwaysLogMessages { get; }
    }
}
