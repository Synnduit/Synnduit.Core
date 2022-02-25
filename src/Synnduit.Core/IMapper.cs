using System;

namespace Synnduit
{
    /// <summary>
    /// Maps source system entity IDs to their destination system counterparts. 
    /// </summary>
    public interface IMapper
    {
        /// <summary>
        /// Maps the specified source system entity ID (of the specified type) to its
        /// destination system counterpart.
        /// </summary>
        /// <param name="entityTypeId">The ID of the entity type.</param>
        /// <param name="sourceSystemEntityId">
        /// The ID that uniquely identifies the entity in the current source system.
        /// </param>
        /// <returns>
        /// The ID that uniquely identifies the entity in the destination system; if the
        /// specified source system entity ID isn't mapped, null will be returned.
        /// </returns>
        EntityIdentifier GetDestinationSystemEntityId(
            Guid entityTypeId,
            EntityIdentifier sourceSystemEntityId);

        /// <summary>
        /// Maps the specified source system entity ID (of the specified type) to its
        /// destination system counterpart.
        /// </summary>
        /// <param name="entityTypeId">The ID of the entity type.</param>
        /// <param name="sourceSystemId">The ID of the entity's source system.</param>
        /// <param name="sourceSystemEntityId">
        /// The ID that uniquely identifies the entity in the specified source system.
        /// </param>
        /// <returns>
        /// The ID that uniquely identifies the entity in the destination system; if the
        /// specified source system entity ID isn't mapped, null will be returned.
        /// </returns>
        EntityIdentifier GetDestinationSystemEntityId(
            Guid entityTypeId,
            Guid sourceSystemId,
            EntityIdentifier sourceSystemEntityId);
    }
}
