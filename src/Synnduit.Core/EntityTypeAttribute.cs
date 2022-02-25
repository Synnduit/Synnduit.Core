using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote classes that represent entity types.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class EntityTypeAttribute : EntityTypeAttributeBase
    {
        /// <summary>
        /// Initializes a new instance of the class and sets the ID of the entity type and
        /// the type representing its parent destination system.
        /// </summary>
        /// <param name="id">
        /// The ID of the entity type; the value must be parsable as a <see cref="Guid" />.
        /// </param>
        /// <param name="destinationSystem">
        /// The type representing the entity type's parent destination system (i.e., the
        /// class that the <see cref="ExternalSystemAttribute" /> attribute is applied to).
        /// </param>
        public EntityTypeAttribute(string id, Type destinationSystem)
            : base(id, destinationSystem)
        { }
    }
}
