using Synnduit.Properties;
using System;

namespace Synnduit
{
    /// <summary>
    /// When applied to an entity property (<see cref="EntityPropertyAttribute"/>), forces the
    /// propagation of null values during deduplication for the specified source systems.
    /// </summary>
    /// <seealso cref="EntityPropertyAttribute" />
    [AttributeUsage(
        AttributeTargets.Property,
        Inherited = true,
        AllowMultiple = false)]
    public class ForceNullPropagationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class and sets the collection of types representing
        /// the source systems that the behavior shall apply to.
        /// </summary>
        /// <param name="sourceSystemTypes">
        /// The collection of types representing the source systems that the behavior shall apply
        /// to.
        /// </param>
        public ForceNullPropagationAttribute(params Type[] sourceSystemTypes)
        {
            ArgumentValidator.EnsureArgumentsNotNullAndUnique(
                sourceSystemTypes, nameof(sourceSystemTypes));
            if (sourceSystemTypes.Length == 0)
            {
                throw new ArgumentException(
                    Resources.AtLeastOneSourceSystemMustBeSpecified,
                    nameof(sourceSystemTypes));
            }
            this.SourceSystemTypes = sourceSystemTypes;
        }

        /// <summary>
        /// Gets the collection of types representing the source systems that the behavior shall
        /// apply to.
        /// </summary>
        public Type[] SourceSystemTypes { get; }
    }
}
