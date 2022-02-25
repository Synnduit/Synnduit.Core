using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote properties that represent the ID that uniquely identifies an entity
    /// in the destination system.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        Inherited = true,
        AllowMultiple = false)]
    public sealed class DestinationSystemIdentifierAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public DestinationSystemIdentifierAttribute()
        { }
    }
}
