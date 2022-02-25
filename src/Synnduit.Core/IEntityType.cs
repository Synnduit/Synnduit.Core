using System;
using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Exposes entity type information.
    /// </summary>
    public interface IEntityType
    {
        /// <summary>
        /// Gets the ID of the entity type.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the name of the entity type.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the entity type's parent destination system.
        /// </summary>
        IExternalSystem DestinationSystem { get; }

        /// <summary>
        /// Gets the type that represents the entity.
        /// </summary>
        /// <remarks>
        /// The type representing the entity need not represent it uniquely: The same CLR
        /// type may represent multiple entity types.
        /// </remarks>
        Type Type { get; }

        /// <summary>
        /// Gets a value indicating whether instances of the entity type are mutable; i.e.,
        /// whether or not they may change between runs.
        /// </summary>
        bool IsMutable { get; }

        /// <summary>
        /// Gets a value indicating whether source system instances of the entity type may
        /// be duplicates (i.e., represent the same destination system entity); in other
        /// words, this value indicates whether or not source system entity instances
        /// should be deduplicated.
        /// </summary>
        bool IsDuplicable { get; }

        /// <summary>
        /// Gets the collection of source systems that the current source system shares
        /// identifiers for the entity type represented by the current instance with.
        /// </summary>
        /// <remarks>
        /// If the current run segment type doesn't require a source system and no source
        /// system is specified, this property shall return a null reference.
        /// </remarks>
        IEnumerable<IExternalSystem> SharedIdentifierSourceSystems { get; }
    }
}
