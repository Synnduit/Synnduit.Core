using System.Collections.Generic;

namespace Synnduit
{
    /// <summary>
    /// Represents a collection of source system entities.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    /// <remarks>
    /// Instances of classes implementing this interface are to be returned by individual
    /// <see cref="IFeed{TEntity}" /> implementations. This level of indirection (i.e.,
    /// returning instances of this interface, as opposed to simply returning collections
    /// of entities) allows individual feeds to load the entities on a just-in-time basis,
    /// while at the same time providing the entity count upfront. As opposed to preloading
    /// entire collection, the feed may utilize, for example, an ADO.NET data reader to
    /// load the entities as the collection is being iterated over. This could prove a
    /// useful memory optimization in situations where the number of entities is very
    /// large. If this approach is taken, a separate database call will be required to get
    /// the entity count. If, on the other hand, this is not required, implementers can
    /// take advantage of the <see cref="EntityCollection{TEntity}" /> class that simply
    /// preloads the entire collection upfront.
    /// </remarks>
    public interface IEntityCollection<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets the number of entities contained in the collection.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the collection of entities.
        /// </summary>
        IEnumerable<TEntity> Entities { get; }
    }
}
