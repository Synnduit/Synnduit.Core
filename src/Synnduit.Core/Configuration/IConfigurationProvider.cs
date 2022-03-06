using Microsoft.Extensions.Configuration;

namespace Synnduit.Configuration
{
    /// <summary>
    /// Provides access to application configuration.
    /// </summary>
    public interface IConfigurationProvider
    {
        /// <summary>
        /// Gets the <see cref="IConfiguration"/> instance that provides access to all
        /// configuration information.
        /// </summary>
        IConfiguration Configuration { get; }

        /// <summary>
        /// Gets the current application configuration.
        /// </summary>
        IApplicationConfiguration ApplicationConfiguration { get; }
    }
}
