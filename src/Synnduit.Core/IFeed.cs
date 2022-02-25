namespace Synnduit
{
    /// <summary>
    /// The interface to be implemented by individual source system "feeds", classes
    /// loading entities from individual source systems.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IFeed<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Loads and returns entities from the source system represented by the current
        /// instance.
        /// </summary>
        /// <returns>
        /// The collection of entities from the source system represented by the current
        /// instance.
        /// </returns>
        IEntityCollection<TEntity> LoadEntities();
    }
}
