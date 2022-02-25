using System;
using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Used to denote classes that represent feeds.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = true)]
    public sealed class FeedAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class and sets the type representing the
        /// entity.
        /// </summary>
        /// <param name="entityTypes">
        /// The collection of types representing the entities.
        /// </param>
        public FeedAttribute(params Type[] entityTypes)
        {
            ArgumentValidator.EnsureArgumentsNotNullAndUnique(
                entityTypes, nameof(entityTypes));
            this.EntityTypes = entityTypes;
            this.SourceSystem = null;
            this.OrphanMappingBehavior = 0;
        }

        /// <summary>
        /// Gets the collection of types representing the entities.
        /// </summary>
        public IEnumerable<Type> EntityTypes { get; }

        /// <summary>
        /// Gets or sets the type representing the cache feed's source system.
        /// </summary>
        public Type SourceSystem { get; set; }

        /// <summary>
        /// Gets or sets the orphan mapping behavior to be applied to entities from the
        /// feed represented by the instance.
        /// </summary>
        public OrphanMappingBehavior OrphanMappingBehavior { get; set; }
    }
}
