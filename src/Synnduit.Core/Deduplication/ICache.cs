using System;
using System.Collections.Generic;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Represents an in-memory entity cache to be used for deduplication purposes.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface ICache<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets the collection of all entities currently in the cache.
        /// </summary>
        /// <returns>The collection of all entities currently in the cache.</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Creates an index for the specified entity value.
        /// </summary>
        /// <typeparam name="TValue">The indexed value type.</typeparam>
        /// <param name="valueGetter">
        /// Used to get the indexed value from an entity instance.
        /// </param>
        /// <returns>The cache index created.</returns>
        ICacheIndex<TEntity, TValue>
            CreateIndex<TValue>(Func<TEntity, TValue> valueGetter);
    }
}
