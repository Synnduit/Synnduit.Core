using System;
using System.Collections.Generic;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// The base class for individual deduplication rules that are used to detect duplicate
    /// entities.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public abstract class DuplicationRule<TEntity> : IDuplicationRule<TEntity>
        where TEntity : class
    {
        private readonly Lazy<IContext> context;

        private readonly Lazy<ICache<TEntity>> cache;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        protected DuplicationRule()
        {
            this.context = new Lazy<IContext>(
                DependencyContainer.Instance.Get<IContext>);
            this.cache = new Lazy<ICache<TEntity>>(
                DependencyContainer.Instance.Get<ICache<TEntity>>);
        }

        /// <summary>
        /// Gets the collection of duplicates for the specified entity.
        /// </summary>
        /// <param name="entity">The entity that is being deduplicated.</param>
        /// <returns>
        /// The collection of duplicates, as detected by the rule represented by the
        /// current instance.
        /// </returns>
        public abstract IEnumerable<Duplicate> GetDuplicates(TEntity entity);

        /// <summary>
        /// Gets the <see cref="IContext" /> implementation used by the current instance.
        /// </summary>
        protected IContext Context
        {
            get { return this.context.Value; }
        }

        /// <summary>
        /// Gets the <see cref="ICache{TEntity}" /> implementation used by the current
        /// instance.
        /// </summary>
        protected ICache<TEntity> Cache
        {
            get { return this.cache.Value; }
        }
    }
}
