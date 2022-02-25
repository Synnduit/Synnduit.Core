using System;

namespace Synnduit.Deduplication
{
    /// <summary>
    /// Used to denote classes that represent value homogenizers.
    /// </summary>
    /// <seealso cref="IHomogenizer" />
    /// <seealso cref="Homogenizer{TValue}" />
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class HomogenizerAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public HomogenizerAttribute()
        { }
    }
}
