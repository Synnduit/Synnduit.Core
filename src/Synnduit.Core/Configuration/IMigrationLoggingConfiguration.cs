namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the application's migration logging behavior configuration.
    /// </summary>
    public interface IMigrationLoggingConfiguration
    {
        /// <summary>
        /// Gets a comma-separated list of <see cref="EntityTransactionOutcome"/> values
        /// identifying entity transactions that should be excluded from logging; the default is
        /// <see cref="EntityTransactionOutcome.Skipped" /> and
        /// <see cref="EntityTransactionOutcome.NoChangesDetected"/>.
        /// </summary>
        string ExcludedOutcomes { get; }

        /// <summary>
        /// Gets a value indicating whether the source system entity should be recorded in the log;
        /// the default is true.
        /// </summary>
        bool SourceSystemEntity { get; }

        /// <summary>
        /// Gets a value indicating whether the destination system entity should be recorded in the
        /// log; the default is false.
        /// </summary>
        bool DestinationSystemEntity { get; }

        /// <summary>
        /// Gets a value indicating whether individual value changes should be recorded in the log;
        /// the default is true.
        /// </summary>
        bool ValueChanges { get; }

        /// <summary>
        /// Gets a value indicating whether an entity transaction should always be logged if there
        /// is at least one message associated with it, (possibly) effectively overriding the
        /// <see cref="ExcludedOutcomes" /> values; the default is false.
        /// </summary>
        bool AlwaysLogMessages { get; }
    }
}
