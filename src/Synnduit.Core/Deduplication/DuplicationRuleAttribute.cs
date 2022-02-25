using System;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Used to denote classes that represent duplication rules.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class DuplicationRuleAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public DuplicationRuleAttribute()
        { }
    }
}
