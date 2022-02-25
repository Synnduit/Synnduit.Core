using System;
using System.Collections.Generic;

namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for interfaces representing the event data for individual
    /// "operation completed" events.
    /// </summary>
    /// <remarks>
    /// This interface is used for events that can have log messages and/or exceptions
    /// associated with them. If this is not the case, the interface for the event's data
    /// will extend <see cref="IOperationArgs" /> directly, even though it may be for an
    /// "operation completed" event.
    /// </remarks>
    public interface IOperationCompletedArgs : IOperationArgs
    {
        /// <summary>
        /// Gets the collection of log messages associated with the operation.
        /// </summary>
        IEnumerable<ILogMessage> LogMessages { get; }

        /// <summary>
        /// Gets the exception that the operation resulted in; a null reference will be
        /// returned if this is not applicable.
        /// </summary>
        Exception Exception { get; }
    }
}
