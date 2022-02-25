using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Allows individual classes to register for invocation during the initialization
    /// process.
    /// </summary>
    public interface IInitializer
    {
        /// <summary>
        /// Registers the specified instance for invocation during the initialization
        /// process; should be called in individual classes' constructors.
        /// </summary>
        /// <param name="instance">The initializable instance to be invoked.</param>
        /// <param name="suppressEvents">
        /// A value indicating whether initialization events (i.e., initializing and
        /// initialized) should be suppressed.
        /// </param>
        /// <param name="message">
        /// An optional message to be sent to the initialization event receivers.
        /// </param>
        /// <param name="data">
        /// An optional dictionary of data values to be sent to the initialization event
        /// receivers.
        /// </param>
        void Register(
            IInitializable instance,
            bool suppressEvents = false,
            string message = null,
            IDictionary<string, object> data = null);
    }
}
