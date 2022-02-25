using System;

namespace Synnduit
{
    /// <summary>
    /// Performs conversions between <see cref="EntityIdentifier" /> instances and
    /// compatible types (i.e., those types that implicit or explicit cast operators
    /// to/from EntityIdentifier exist for).
    /// </summary>
    public interface IEntityIdentifierConverter
    {
        /// <summary>
        /// Creates an <see cref="EntityIdentifier" /> instance by converting the specified
        /// <see cref="object" /> instance.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        /// A <see cref="EntityIdentifier" /> instance created by converting the specified
        /// <see cref="object" /> instance.
        /// </returns>
        EntityIdentifier FromValue(object value);

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to an instance
        /// of the specified type.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <param name="type">The target type.</param>
        /// <returns>
        /// The specified <see cref="EntityIdentifier" /> converted to the specified type.
        /// </returns>
        object ToValue(EntityIdentifier identifier, Type type);
    }
}
