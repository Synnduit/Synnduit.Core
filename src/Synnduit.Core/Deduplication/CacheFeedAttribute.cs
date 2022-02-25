using System;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Used to denote classes that represent cache feeds.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class CacheFeedAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public CacheFeedAttribute()
        { }

        /// <summary>
        /// Gets or sets the type representing the cache feed's destination system.
        /// </summary>
        /// <remarks>
        /// This property only applies to (open) generic cache feeds. Non-generic cache
        /// feeds are always defined for specific entity types inferred from the generic
        /// argument (or arguments) of its implementation (or implementations) of the
        /// <see cref="ICacheFeed{TEntity}"/> interface.
        /// </remarks>
        public Type DestinationSystem { get; set; }
    }
}
