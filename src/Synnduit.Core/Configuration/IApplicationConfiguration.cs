using System.Collections.Generic;

namespace Synnduit.Configuration
{
    /// <summary>
    /// Represents the application's configuration.
    /// </summary>
    public interface IApplicationConfiguration : IConfigurationBase
    {
        /// <summary>
        /// Gets the name of the connection string to be used by the application for its database.
        /// </summary>
        string ConnectionStringName { get; }

        /// <summary>
        /// Gets the binary files directory path; the exports from the DLL files in this directory
        /// shall be loaded.
        /// </summary>
        string BinaryFilesDirectoryPath { get; }

        /// <summary>
        /// Gets the application's logging behavior configuration.
        /// </summary>
        ILoggingConfiguration Logging { get; }

        /// <summary>
        /// Gets the collection of supported runs.
        /// </summary>
        IEnumerable<IRunConfiguration> Runs { get; }
    }
}
