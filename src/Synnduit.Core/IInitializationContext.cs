using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Exposes initialization-related functionality.
    /// </summary>
    public interface IInitializationContext
    {
        /// <summary>
        /// Gets or sets the message to be passed to the event that's raised when the
        /// initialization is complete.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Gets the dictionary of data values to be passed ot the event that's raised
        /// when the initialization is complete.
        /// </summary>
        IDictionary<string, object> Data { get; }
    }
}
