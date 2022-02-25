using System.Collections.Generic;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// To be implemented by individual deduplication rules that are used to detect
    /// duplicate entities.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IDuplicationRule<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets the collection of duplicates for the specified entity.
        /// </summary>
        /// <param name="entity">The entity that is being deduplicated.</param>
        /// <returns>
        /// The collection of duplicates, as detected by the rule represented by the
        /// current instance.
        /// </returns>
        IEnumerable<Duplicate> GetDuplicates(TEntity entity);
    }
}
