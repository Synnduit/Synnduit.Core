using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Provides information relevant to the run segment that's currently being executed.
    /// </summary>
    /// <remarks>
    /// Not all proprety values that this interface exposes are relevant to all segment
    /// types. Those that aren't relevant to the current segment type will return null
    /// references. See the remarks sections of individual properties for details.
    /// </remarks>
    public interface IContext
    {
        /// <summary>
        /// Gets the type of the current run segment.
        /// </summary>
        SegmentType SegmentType { get; }

        /// <summary>
        /// Gets the one-based index of the current run segment.
        /// </summary>
        int SegmentIndex { get; }

        /// <summary>
        /// Gets the number of segments in the current run.
        /// </summary>
        int SegmentCount { get; }

        /// <summary>
        /// Gets source system information.
        /// </summary>
        IExternalSystem SourceSystem { get; }

        /// <summary>
        /// Gets destination system information.
        /// </summary>
        IExternalSystem DestinationSystem { get; }

        /// <summary>
        /// Gets entity type infromation.
        /// </summary>
        IEntityType EntityType { get; }

        /// <summary>
        /// Gets the collection of all registered external systems.
        /// </summary>
        IEnumerable<IExternalSystem> ExternalSystems { get; }

        /// <summary>
        /// Gets the collection of all registered entity types.
        /// </summary>
        IEnumerable<IEntityType> EntityTypes { get; }

        /// <summary>
        /// Gets the consolidated dictionary of parameters applicable to the current run
        /// segment.
        /// </summary>
        IReadOnlyDictionary<string, string> Parameters { get; }

        /// <summary>
        /// Gets the run data; this dictionary allows individual feeds, sinks, and services
        /// to preserve arbitrary pieces of data between run segments.
        /// </summary>
        IDictionary<string, object> RunData { get; }
    }
}
