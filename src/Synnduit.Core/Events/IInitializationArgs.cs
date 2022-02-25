using System;
using System.Collections.Generic;

namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for interfaces representing the event data for individual
    /// subsystem initialization events (i.e., initializing and initialized).
    /// </summary>
    public interface IInitializationArgs
    {
        /// <summary>
        /// Gets the type implementing the <see cref="IInitializable" /> interface that is
        /// being used to perform the initialization.
        /// </summary>
        Type InitializableType { get; }

        /// <summary>
        /// Gets the dictionary of data values associated with the initialization of the
        /// subsystem.
        /// </summary>
        IReadOnlyDictionary<string, object> Data { get; }
    }
}
