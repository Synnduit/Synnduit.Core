using System;
using System.Collections.Generic;
using Synnduit.Properties;

namespace Synnduit
{
    /// <summary>
    /// When applied to a class that represents an entity type, specifies a set of source
    /// (external) systems that share identifiers (for the entity type).
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        Inherited = false,
        AllowMultiple = true)]
    public sealed class SharedSourceSystemIdentifiersAttribute : Attribute
    {
        private IEnumerable<Type> sourceSystemTypes;

        /// <summary>
        /// Initializes a new instance of the class and sets the collection of types
        /// representing the source systems that share identifiers for the entity type
        /// represented by the class that the attribute is applied to.
        /// </summary>
        /// <param name="sourceSystemTypes">
        /// The collection of types representing the source systems that share identifiers
        /// for the entity type represented by the class that the attribute is applied to.
        /// </param>
        public SharedSourceSystemIdentifiersAttribute(params Type[] sourceSystemTypes)
        {
            ArgumentValidator.EnsureArgumentsNotNullAndUnique(
                sourceSystemTypes, nameof(sourceSystemTypes));
            if(sourceSystemTypes.Length == 0)
            {
                throw new ArgumentException(
                    Resources.AtLeastOneSourceSystemMustBeSpecified,
                    nameof(sourceSystemTypes));
            }
            this.sourceSystemTypes = sourceSystemTypes;
        }

        /// <summary>
        /// Gets the collection of types representing the source systems that share
        /// identifiers for the entity type represented by the class that the attribute is
        /// applied to.
        /// </summary>
        public IEnumerable<Type> SourceSystemTypes
        {
            get { return this.sourceSystemTypes; }
        }
    }
}
