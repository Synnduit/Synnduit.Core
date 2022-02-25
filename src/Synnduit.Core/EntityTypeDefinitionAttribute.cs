using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote classes that represent entity type definitions.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class EntityTypeDefinitionAttribute : EntityTypeAttributeBase
    {
        /// <summary>
        /// Initializes a new instance of the class and sets the ID of the entity type, the
        /// type representing the entity, and the type representing its parent destination
        /// system.
        /// </summary>
        /// <param name="id">
        /// The ID of the entity type; the value must be parsable as a <see cref="Guid" />.
        /// </param>
        /// <param name="entityType">The type representing the entity.</param>
        /// <param name="destinationSystem">
        /// The type representing the entity type's parent destination system (i.e., the
        /// class that the <see cref="ExternalSystemAttribute" /> attribute is applied to).
        /// </param>
        public EntityTypeDefinitionAttribute(
            string id, Type entityType, Type destinationSystem)
            : base(id, destinationSystem)
        {
            ArgumentValidator.EnsureArgumentNotNull(entityType, nameof(entityType));
            this.EntityType = entityType;
        }

        /// <summary>
        /// Gets the type representing the entity.
        /// </summary>
        public Type EntityType { get; }
    }
}
