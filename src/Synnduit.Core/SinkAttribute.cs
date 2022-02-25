using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote classes that represent sinks.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class SinkAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public SinkAttribute()
        { }

        /// <summary>
        /// Gets or sets the type representing the sink's destination system.
        /// </summary>
        /// <remarks>
        /// This property only applies to (open) generic sinks. Non-generic sinks are
        /// always defined for specific entity types inferred from the generic argument (or
        /// arguments) of its implementation (or implementations) of the
        /// <see cref="ISink{TEntity}" /> interface.
        /// </remarks>
        public Type DestinationSystem { get; set; }
    }
}
