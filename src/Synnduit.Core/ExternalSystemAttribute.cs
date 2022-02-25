using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote classes that represent external systems.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class ExternalSystemAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class and sets the ID of the external system.
        /// </summary>
        /// <param name="id">
        /// The ID of the external system; the value must be parsable as a
        /// <see cref="Guid" />.
        /// </param>
        public ExternalSystemAttribute(string id)
        {
            this.Id = ArgumentValidator.EnsureArgumentValidGuid(id, nameof(id));
            this.Name = null;
            this.GarbageCollectionBehavior = 0;
            this.OrphanMappingBehavior = 0;
        }

        /// <summary>
        /// Gets the ID of the external system.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets or sets the name of the external system.
        /// </summary>
        /// <remarks>
        /// This value is optional; if not specified, the class name (without namespace)
        /// will be used as the external system name.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the orphan mapping behavior to be applied to the external
        /// (destination) system's entities.
        /// </summary>
        public OrphanMappingBehavior OrphanMappingBehavior { get; set; }

        /// <summary>
        /// Gets or sets the garbage collection behavior to be applied to the external
        /// (destination) system's entities.
        /// </summary>
        public GarbageCollectionBehavior GarbageCollectionBehavior { get; set; }
    }
}
