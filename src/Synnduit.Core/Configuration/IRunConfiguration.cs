using System.Collections.Generic;

namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the configuration of a single run.
    /// </summary>
    public interface IRunConfiguration : IConfigurationBase
    {
        /// <summary>
        /// Gets the name of the run.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the ordered collection of the segments that comprise the run.
        /// </summary>
        IEnumerable<ISegmentConfiguration> Segments { get; }
    }
}
