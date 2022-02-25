using System;

namespace Synnduit.Events
{
    /// <summary>
    /// The base interface for interfaces representing the event data for individual
    /// operation-related events.
    /// </summary>
    public interface IOperationArgs
    {
        /// <summary>
        /// Gets the operation's time stamp.
        /// </summary>
        DateTimeOffset TimeStamp { get; }
    }
}
