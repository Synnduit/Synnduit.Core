namespace Synnduit.Configuration
{
    /// <summary>
    /// The base interface for interfaces representing the application/run/segment configuration.
    /// </summary>
    public interface IConfigurationBase
    {
        /// <summary>
        /// Gets the name of the source system.
        /// </summary>
        string SourceSystem { get; }
    }
}
