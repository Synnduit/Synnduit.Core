using System;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Used to denote those properties of individual entity classes that represent
    /// duplication keys; if the values of a duplication key property match in two
    /// entities, the entities are considered duplicates of the same real-world entity.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        Inherited = true,
        AllowMultiple = false)]
    public class DuplicationKeyAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public DuplicationKeyAttribute()
        { }
    }
}
