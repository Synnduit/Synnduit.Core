using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// To be implemented by individual destination system entity sinks.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface ISink<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets the collection of IDs of entities that currently exist in the system.
        /// </summary>
        /// <returns>
        /// The collection of IDs of entities that currently exist in the system.
        /// </returns>
        /// <remarks>
        /// This method need not be implemented if you don't intend to use garbage
        /// collection.
        /// </remarks>
        IEnumerable<EntityIdentifier> GetEntityIdentifiers();

        /// <summary>
        /// Creates a new empty instance of an entity represented by the current entity
        /// type.
        /// </summary>
        /// <returns>
        /// A new empty instance of an entity represented by the current entity type.
        /// </returns>
        /// <remarks>
        /// This method is used when creating new instances in the destination system.
        /// The New method gets called first, the source system entity is merged into
        /// this blank instance, upon which the Create method gets invoked to actually
        /// persist the newly created entity (in the destination system).
        /// </remarks>
        TEntity New();

        /// <summary>
        /// Creates a new entity instance in the destination system.
        /// </summary>
        /// <param name="entity">The entity instance to create.</param>
        /// <returns>
        /// The entity created; may be the same instance as the parameter passed to the
        /// method or another instance, as long as its destination system entity identifier
        /// value is populated.
        /// </returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// Gets the specified entity instance from the destination system.
        /// </summary>
        /// <param name="id">The ID of the requested entity instance.</param>
        /// <returns>The requested entity instance.</returns>
        /// <remarks>
        /// The entity instance returned by this method is used in data merging, and all
        /// of its data properties must be populated. If no entity instance with the
        /// specified ID exists in the destination system, this method must return null.
        /// This method need not be supported if the entity type represented by the current
        /// instance represents an immutable entity type.
        /// </remarks>
        TEntity Get(EntityIdentifier id);

        /// <summary>
        /// Updates the specified entity instance in the destination system.
        /// </summary>
        /// <param name="entity">The updated entity instance.</param>
        /// <remarks>
        /// This method need not be implemented if the entity type represented by the
        /// current instance represents an immutable entity type.
        /// </remarks>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes the specified entity instance in the destination system.
        /// </summary>
        /// <param name="entity">The entity instance to delete.</param>
        /// <remarks>
        /// This method need not be implemented if you don't intend to use garbage
        /// collection.
        /// </remarks>
        void Delete(TEntity entity);
    }
}
