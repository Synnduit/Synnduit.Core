using System;

namespace Synnduit
{
    /// <summary>
    /// Exposes external system information.
    /// </summary>
    public interface IExternalSystem
    {
        /// <summary>
        /// Gets the ID of the external system.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the name of the external system.
        /// </summary>
        string Name { get; }
    }
}
