using System;

namespace Synnduit
{
    /// <summary>
    /// When applied to a class representing an external system (i.e., one decorated with
    /// <see cref="ExternalSystemAttribute" />), specifies the values of parameters
    /// associated with the external system when acting as a source system.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public class SourceSystemParametersAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public SourceSystemParametersAttribute()
        { }

        /// <summary>
        /// Gets or sets the orphan mapping behavior to be applied to entities originating
        /// in the source (external) system.
        /// </summary>
        public OrphanMappingBehavior OrphanMappingBehavior { get; set; }
    }
}
