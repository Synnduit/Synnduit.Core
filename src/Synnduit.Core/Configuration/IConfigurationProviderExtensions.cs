using Microsoft.Extensions.Configuration;
using Synnduit.Properties;
using System;

namespace Synnduit.Configuration
{
    /// <summary>
    /// Extension methods for the <see cref="IConfigurationProvider"/> interface.
    /// </summary>
    public static class IConfigurationProviderExtensions
    {
        /// <summary>
        /// Gets the database connection string to be used by the application.
        /// </summary>
        /// <param name="configurationProvider">
        /// The <see cref="IConfigurationProvider"/> instance that provides access to the
        /// application configuration.
        /// </param>
        /// <returns>The database connection string to be used by the application.</returns>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="IApplicationConfiguration.ConnectionStringName"/> is invalid or the
        /// connection string isn't specified.
        /// </exception>
        public static string GetConnectionString(
            this IConfigurationProvider configurationProvider)
        {
            var connectionStringName =
                configurationProvider.ApplicationConfiguration.ConnectionStringName;
            if (string.IsNullOrWhiteSpace(connectionStringName))
            {
                throw new InvalidOperationException(Resources.ConnectionStringNameNotSpecified);
            }
            var connectionString =
                configurationProvider
                .Configuration
                .GetConnectionString(connectionStringName);
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(string.Format(
                    Resources.ConnectionStringNotFound, connectionStringName));
            }
            return connectionString;
        }
    }
}
