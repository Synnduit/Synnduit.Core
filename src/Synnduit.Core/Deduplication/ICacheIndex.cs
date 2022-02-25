using System.Collections.Generic;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Provides access to cached entities by indexed value.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    /// <typeparam name="TValue">The indexed value type.</typeparam>
    public interface ICacheIndex<TEntity, TValue>
        where TEntity : class
    {
        /// <summary>
        /// Gets all entities with the specified indexed value.
        /// </summary>
        /// <param name="value">
        /// The requested value; if null is passed here, an empty collection will always
        /// be returned.
        /// </param>
        /// <returns>The collection of entities with the specified value.</returns>
        IEnumerable<TEntity> GetEntities(TValue value);
    }
}
