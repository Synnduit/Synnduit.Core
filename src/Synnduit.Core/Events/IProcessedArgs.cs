using System.Collections.Generic;

namespace Synnduit.Events
{
    /// <summary>
    /// The event data for event that occurs when a source system entity has been
    /// processed.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    /// <remarks>
    /// If the process results in an exception, the property values exposed by the instance
    /// implementing this interface are not guaranteed to be in a consistent state. E.g.,
    /// you could end up in a situation where the value of the
    /// <see cref="IProcessedArgs{TEntity}.SourceSystemEntity" /> property is populated,
    /// but the <see cref="IProcessedArgs{TEntity}.SourceSystemEntityId" /> property
    /// returns a null reference. This will happen if the retrieval of the ID that uniquely
    /// identifies the entity in the source system throws an exception. As any step in the
    /// process can potentially result in an exception, you should not make assumptions
    /// about property values being populated if
    /// <see cref="IProcessedArgs{TEntity}.Outcome" /> is
    /// <see cref="EntityTransactionOutcome.ExceptionThrown"/>.
    /// </remarks>
    public interface IProcessedArgs<TEntity> : IOperationCompletedArgs
        where TEntity : class
    {
        /// <summary>
        /// Gets the source system entity.
        /// </summary>
        TEntity SourceSystemEntity { get; }

        /// <summary>
        /// Gets the ID that uniquely identifies the entity in its source system.
        /// </summary>
        EntityIdentifier SourceSystemEntityId { get; }

        /// <summary>
        /// Gets the destination system entity; a null reference will be returned if this
        /// is not applicable.
        /// </summary>
        TEntity DestinationSystemEntity { get; }

        /// <summary>
        /// Gets the ID that uniquely identifies the entity in the destination system; a
        /// null reference will be returned if this is not applicable.
        /// </summary>
        EntityIdentifier DestinationSystemEntityId { get; }

        /// <summary>
        /// Gets the outcome of the processing.
        /// </summary>
        EntityTransactionOutcome Outcome { get; }

        /// <summary>
        /// Gets the serialized source system entity; a null reference will be returned if
        /// the process fails before serializing the entity.
        /// </summary>
        ISerializedEntity SerializedSourceSystemEntity { get; }

        /// <summary>
        /// Gets the collection of value changes applied; an empty collection will be
        /// returned if this is not applicable.
        /// </summary>
        IEnumerable<IValueChange> ValueChanges { get; }
    }
}
