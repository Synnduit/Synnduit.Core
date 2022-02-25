using System;

namespace Synnduit.Preprocessing
{
    /// <summary>
    /// Used to denote classes that represent preprocessor operations.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class PreprocessorOperationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public PreprocessorOperationAttribute()
        { }
    }
}
