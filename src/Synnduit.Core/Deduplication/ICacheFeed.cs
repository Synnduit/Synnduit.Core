using System.Collections.Generic;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// To be implemented by individual destination system entity cache feeds; used to
    /// populate the in-memory cache used in deduplication.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface ICacheFeed<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Loads the collection of entities (of the type represented by the current
        /// instance) that currently exist in the destination system.
        /// </summary>
        /// <returns>
        /// The collection of entities that currently exist in the destination system.
        /// </returns>
        /// <remarks>
        /// The collection returned by this method is used to populate the entity cache
        /// that is passed to individual duplication rules. The instances returned need not
        /// have all of their data properties populated: The destination system ID should
        /// always be set, along with any properties used by the duplication rules.
        /// </remarks>
        IEnumerable<TEntity> LoadEntities();
    }
}
