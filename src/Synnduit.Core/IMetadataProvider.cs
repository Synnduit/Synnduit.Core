namespace Synnduit
{
    /// <summary>
    /// Extracts entity-related information that the system needs for entity processing.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    /// <remarks>
    /// This interface should never be injected directly; use
    /// <see cref="ISafeMetadataProvider{TEntity}"/> instead.
    /// </remarks>
    public interface IMetadataProvider<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets the ID that uniquely identifies the specified entity in its source system.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The ID that uniquely identifies the entity in its source system.
        /// </returns>
        EntityIdentifier GetSourceSystemEntityId(TEntity entity);

        /// <summary>
        /// Gets the ID that uniquely identifies the specified entity in the destination
        /// system.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The ID that uniquely identifies the entity in the destination system.
        /// </returns>
        EntityIdentifier GetDestinationSystemEntityId(TEntity entity);

        /// <summary>
        /// Gets the specified entity's label (i.e., name or short description).
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The entity label (i.e., name or short description).</returns>
        string GetLabel(TEntity entity);
    }
}
