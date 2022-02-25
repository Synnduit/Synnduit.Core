using System;

namespace Synnduit
{
    /// <summary>
    /// The base class for individual source system "feeds", classes loading entities from
    /// individual source systems.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public abstract class Feed<TEntity> : IFeed<TEntity>
        where TEntity : class
    {
        private readonly Lazy<IContext> context;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        protected Feed()
        {
            this.context = new Lazy<IContext>(
                DependencyContainer.Instance.Get<IContext>);
        }

        /// <summary>
        /// Loads and returns entities from the source system represented by the current
        /// instance.
        /// </summary>
        /// <returns>
        /// The collection of entities from the source system represented by the current
        /// instance.
        /// </returns>
        public abstract IEntityCollection<TEntity> LoadEntities();

        /// <summary>
        /// Gets the <see cref="IContext" /> implementation used by the current instance.
        /// </summary>
        protected IContext Context
        {
            get { return this.context.Value; }
        }
    }
}
