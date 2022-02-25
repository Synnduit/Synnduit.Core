using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Exposes extension methods for working with entity collections.
    /// </summary>
    public static class EntityCollectionExtensions
    {
        /// <summary>
        /// Creates a new <see cref="EntityCollection{TEntity}" /> instance for the
        /// specified collection of entities.
        /// </summary>
        /// <typeparam name="TEntity">The type representing the entity.</typeparam>
        /// <param name="entities">The collection of entities.</param>
        /// <returns>
        /// A <see cref="EntityCollection{TEntity}" /> instance containing the specified
        /// collection of entities.
        /// </returns>
        public static EntityCollection<TEntity>
            ToEntityCollection<TEntity>(this IEnumerable<TEntity> entities)
            where TEntity : class
        {
            return new EntityCollection<TEntity>(entities);
        }
    }
}
