using System.Collections.Generic;
using System.Linq;

namespace Synnduit
{
    /// <summary>
    /// Represents a collection of source system entities.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    /// <remarks>
    /// This implementation of the <see cref="IEntityCollection{TEntity}" /> interface
    /// simply preloads the entire collection upfront; it should be utilized in situations
    /// where just-in-time loading is not required.
    /// </remarks>
    public class EntityCollection<TEntity> : IEntityCollection<TEntity>
        where TEntity : class
    {
        private readonly TEntity[] preloadedEntities;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="entities">The collection of entities.</param>
        public EntityCollection(IEnumerable<TEntity> entities)
        {
            this.preloadedEntities = entities.ToArray();
        }

        /// <summary>
        /// Gets the number of entities contained in the collection.
        /// </summary>
        public int Count
        {
            get { return this.preloadedEntities.Length; }
        }

        /// <summary>
        /// Gets the collection of entities.
        /// </summary>
        public IEnumerable<TEntity> Entities
        {
            get { return this.preloadedEntities; }
        }
    }
}
