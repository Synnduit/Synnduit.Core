using System;

namespace Synnduit
{
    /// <summary>
    /// The base class for <see cref="EntityTypeAttribute" /> and
    /// <see cref="EntityTypeDefinitionAttribute" /> classes.
    /// </summary>
    public abstract class EntityTypeAttributeBase : Attribute
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
        protected EntityTypeAttributeBase(string id, Type destinationSystem)
        {
            this.Id = ArgumentValidator.EnsureArgumentValidGuid(id, nameof(id));
            ArgumentValidator.EnsureArgumentNotNull(
                destinationSystem, nameof(destinationSystem));
            this.DestinationSystem = destinationSystem;
            this.Name = null;
            this.IsMutable = true;
            this.IsDuplicable = true;
            this.OrphanMappingBehavior = 0;
            this.GarbageCollectionBehavior = 0;
            this.SuppressCacheFeed = false;
        }

        /// <summary>
        /// Gets the ID of the entity type.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the type representing the entity type's parent destination system (i.e.,
        /// the class that the <see cref="ExternalSystemAttribute" /> attribute is applied
        /// to).
        /// </summary>
        public Type DestinationSystem { get; }

        /// <summary>
        /// Gets or sets the name of the entity type.
        /// </summary>
        /// <remarks>
        /// This value is optional; if not specified, the class name (without namespace)
        /// will be used as the entity type name.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether instances of the entity type are
        /// mutable; i.e., whether or not they may change between runs; the default is
        /// TRUE.
        /// </summary>
        public bool IsMutable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether source system instances of the entity
        /// type may be duplicates (i.e., represent the same destination system entity); in
        /// other words, this value indicates whether or not source system entity instances
        /// should be deduplicated; the default is TRUE.
        /// </summary>
        public bool IsDuplicable { get; set; }

        /// <summary>
        /// Gets or sets the orphan mapping behavior to be applied to entities of the type
        /// represented by the instance.
        /// </summary>
        public OrphanMappingBehavior OrphanMappingBehavior { get; set; }

        /// <summary>
        /// Gets or sets the garbage collection behavior to be applied to entities of the
        /// type represented by the instance.
        /// </summary>
        public GarbageCollectionBehavior GarbageCollectionBehavior { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether any cache feed implementation should be
        /// suppressed (i.e., not used) for entities of the type represented by this
        /// instance.
        /// </summary>
        /// <remarks>
        /// Suppressing the cache feed can be useful in situations where an open generic
        /// cache feed exists for the entity type's destination system, but you don't want
        /// to use it for this particular entity type, nor do you want to create an
        /// entity-type-specific implementation. In other words, a destination system has
        /// an open generic cache feed, but this particular entity type should have no
        /// cache feed at all.
        /// </remarks>
        public bool SuppressCacheFeed { get; set; }
    }
}
