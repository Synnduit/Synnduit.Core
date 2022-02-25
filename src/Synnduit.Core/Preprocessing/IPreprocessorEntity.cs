namespace Synnduit.Preprocessing
{
    /// <summary>
    /// Exposes information related to the preprocessing of an entity.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IPreprocessorEntity<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets or sets the (source/destination system) entity that is being preprocessed.
        /// </summary>
        /// <remarks>
        /// Each preprocesor operation may modify the existing instance, or replace it with
        /// another instance, as long as the IDs remain unchanged.
        /// </remarks>
        TEntity Entity { get; set; }

        /// <summary>
        /// Gets the origin of the entity that is being preprocessed (source/destination
        /// system).
        /// </summary>
        EntityOrigin Origin { get; }

        /// <summary>
        /// Gets a value indicating whether a mapping to an existing destination system
        /// entity exists for the entity, which is a source system entity; null will be
        /// returned if Origin is DestinationSystem.
        /// </summary>
        bool? MappingExists { get; }

        /// <summary>
        /// Rejects the entity - i.e., prevents it from being processed at this point.
        /// </summary>
        /// <remarks>
        /// Rejecting an entity is not considered an erroneous condition. It can be used,
        /// for example, when a dependency doesn't exist in the destination system, but is
        /// expected to be created later. It is only valid in source system entities.
        /// </remarks>
        void Reject();
    }
}
