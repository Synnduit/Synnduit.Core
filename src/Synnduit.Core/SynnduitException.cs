using System;
using System.Runtime.Serialization;

namespace Synnduit
{
    /// <summary>
    /// Represents Synnduit exceptions.
    /// </summary>
    [Serializable]
    public class SynnduitException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynnduitException" /> class.
        /// </summary>
        public SynnduitException()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynnduitException" /> class and
        /// sets the exception message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SynnduitException(string message)
            : base(message)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynnduitException" /> class and
        /// sets the exception message and the inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">
        /// The <see cref="Exception"/> instance that caused the exception.
        /// </param>
        public SynnduitException(string message, Exception innerException)
            : base(message, innerException)
        { }

        /// <summary>
        /// The constructor for deserialization.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The streaming context.</param>
        protected SynnduitException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
