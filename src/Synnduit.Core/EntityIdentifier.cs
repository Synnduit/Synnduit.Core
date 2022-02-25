using System;
using System.Globalization;
using Synnduit.Properties;

namespace Synnduit
{
    /// <summary>
    /// Represents the identifier of an entity in an external (source/destination) system.
    /// </summary>
    [Serializable]
    public sealed class EntityIdentifier
    {
        /// <summary>
        /// The maximum identifier length (characters).
        /// </summary>
        public const int MaxLength = 512;

        /// <summary>
        /// Determines whether two <see cref="EntityIdentifier" /> instances represent the
        /// same identifier.
        /// </summary>
        /// <param name="identifierOne">
        /// The first <see cref="EntityIdentifier" /> instance to compare, or null.
        /// </param>
        /// <param name="identifierTwo">
        /// The second <see cref="EntityIdentifier" /> instance to compare, or null.
        /// </param>
        /// <returns>
        /// True, if the two instances represent the same identifier (or they're both
        /// null); otherwise, false.
        /// </returns>
        public static bool Equal(
            EntityIdentifier identifierOne, EntityIdentifier identifierTwo)
        {
            bool equal = false;
            if(identifierOne is object && identifierTwo is object)
            {
                equal = identifierOne.Equals(identifierTwo);
            }
            else if(identifierOne is null && identifierTwo is null)
            {
                equal = true;
            }
            return equal;
        }

        /// <summary>
        /// Determines whether two <see cref="EntityIdentifier" /> instances represent the
        /// same identifier.
        /// </summary>
        /// <param name="identifierOne">
        /// The first <see cref="EntityIdentifier" /> instance to compare, or null.
        /// </param>
        /// <param name="identifierTwo">
        /// The second <see cref="EntityIdentifier" /> instance to compare, or null.
        /// </param>
        /// <returns>
        /// True, if the two instances represent the same identifier (or they're both
        /// null); otherwise, false.
        /// </returns>
        public static bool operator ==(
            EntityIdentifier identifierOne, EntityIdentifier identifierTwo)
        {
            return Equal(identifierOne, identifierTwo);
        }

        /// <summary>
        /// Determines whether two <see cref="EntityIdentifier" /> instances represent the
        /// different identifiers.
        /// </summary>
        /// <param name="identifierOne">
        /// The first <see cref="EntityIdentifier" /> instance to compare, or null.
        /// </param>
        /// <param name="identifierTwo">
        /// The second <see cref="EntityIdentifier" /> instance to compare, or null.
        /// </param>
        /// <returns></returns>
        public static bool operator !=(
            EntityIdentifier identifierOne, EntityIdentifier identifierTwo)
        {
            return !Equal(identifierOne, identifierTwo);
        }

        /// <summary>
        /// Converts the specified <see cref="String" /> value to an
        /// <see cref="EntityIdentifier" /> instance.
        /// </summary>
        /// <param name="value">The <see cref="String" /> value to convert.</param>
        /// <returns>The <see cref="EntityIdentifier" /> instance.</returns>
        public static implicit operator EntityIdentifier(string value)
        {
            EntityIdentifier identifier = null;
            if(value != null)
            {
                identifier = new EntityIdentifier(value);
            }
            return identifier;
        }

        /// <summary>
        /// Converts the specified <see cref="Guid" /> value to an
        /// <see cref="EntityIdentifier" /> instance.
        /// </summary>
        /// <param name="value">The <see cref="Guid" /> value to convert.</param>
        /// <returns>The <see cref="EntityIdentifier" /> instance.</returns>
        public static implicit operator EntityIdentifier(Guid value)
        {
            return new EntityIdentifier(value);
        }

        /// <summary>
        /// Converts the specified <see cref="Int32" /> value to an
        /// <see cref="EntityIdentifier" /> instance.
        /// </summary>
        /// <param name="value">The <see cref="Int32" /> value to convert.</param>
        /// <returns>The <see cref="EntityIdentifier" /> instance.</returns>
        public static implicit operator EntityIdentifier(int value)
        {
            return new EntityIdentifier(value);
        }

        /// <summary>
        /// Converts the specified <see cref="Int64" /> value to an
        /// <see cref="EntityIdentifier" /> instance.
        /// </summary>
        /// <param name="value">The <see cref="Int64" /> value to convert.</param>
        /// <returns>The <see cref="EntityIdentifier" /> instance.</returns>
        public static implicit operator EntityIdentifier(long value)
        {
            return new EntityIdentifier(value);
        }

        /// <summary>
        /// Converts the specified <see cref="UInt32" /> value to an
        /// <see cref="EntityIdentifier" /> instance.
        /// </summary>
        /// <param name="value">The <see cref="UInt32" /> value to convert.</param>
        /// <returns>The <see cref="EntityIdentifier" /> instance.</returns>
        public static implicit operator EntityIdentifier(uint value)
        {
            return new EntityIdentifier(value);
        }

        /// <summary>
        /// Converts the specified <see cref="UInt64" /> value to an
        /// <see cref="EntityIdentifier" /> instance.
        /// </summary>
        /// <param name="value">The <see cref="UInt64" /> value to convert.</param>
        /// <returns>The <see cref="EntityIdentifier" /> instance.</returns>
        public static implicit operator EntityIdentifier(ulong value)
        {
            return new EntityIdentifier(value);
        }

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to a
        /// <see cref="String" /> value.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <returns>The <see cref="String" /> value.</returns>
        public static implicit operator string(EntityIdentifier identifier)
        {
            string value = null;
            if(identifier != null)
            {
                value = identifier.Identifier;
            }
            return value;
        }

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to a
        /// <see cref="Guid" /> value.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <returns>The <see cref="Guid" /> value.</returns>
        public static explicit operator Guid(EntityIdentifier identifier)
        {
            return Guid.Parse(identifier.Identifier);
        }

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to a
        /// <see cref="Int32" /> value.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <returns>The <see cref="Int32" /> value.</returns>
        public static explicit operator int(EntityIdentifier identifier)
        {
            return int.Parse(identifier.Identifier, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to a
        /// <see cref="Int64" /> value.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <returns>The <see cref="Int64" /> value.</returns>
        public static explicit operator long(EntityIdentifier identifier)
        {
            return long.Parse(identifier.Identifier, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to a
        /// <see cref="UInt32" /> value.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <returns>The <see cref="UInt32" /> value.</returns>
        public static explicit operator uint(EntityIdentifier identifier)
        {
            return uint.Parse(identifier.Identifier, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the specified <see cref="EntityIdentifier" /> instance to a
        /// <see cref="UInt64" /> value.
        /// </summary>
        /// <param name="identifier">
        /// The <see cref="EntityIdentifier" /> instance to convert.
        /// </param>
        /// <returns>The <see cref="UInt64" /> value.</returns>
        public static explicit operator ulong(EntityIdentifier identifier)
        {
            return ulong.Parse(identifier.Identifier, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// A case-insensitive string representation of the identifier.
        /// </summary>
        private readonly string identifier;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="identifier">
        /// A case-insensitive string representation of the identifier.
        /// </param>
        public EntityIdentifier(string identifier)
        {
            ArgumentValidator.EnsureArgumentNotNull(identifier, nameof(identifier));
            if(identifier.Length > MaxLength)
            {
                throw new ArgumentException(
                    string.Format(Resources.EntityIdentifierTooLong, MaxLength),
                    nameof(identifier));
            }
            this.identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the class for an <see cref="Guid" />
        /// identifier.
        /// </summary>
        /// <param name="identifier">
        /// An <see cref="Guid" /> identifier to be represented by the instance.
        /// </param>
        public EntityIdentifier(Guid identifier)
            : this(identifier.ToString("D"))
        { }

        /// <summary>
        /// Initializes a new instance of the class for an <see cref="Int32" />
        /// identifier.
        /// </summary>
        /// <param name="identifier">
        /// An <see cref="Int32" /> identifier to be represented by the instance.
        /// </param>
        public EntityIdentifier(int identifier)
            : this(identifier.ToString(CultureInfo.InvariantCulture))
        { }

        /// <summary>
        /// Initializes a new instance of the class for an <see cref="Int64" />
        /// identifier.
        /// </summary>
        /// <param name="identifier">
        /// An <see cref="Int64" /> identifier to be represented by the instance.
        /// </param>
        public EntityIdentifier(long identifier)
            : this(identifier.ToString(CultureInfo.InvariantCulture))
        { }

        /// <summary>
        /// Initializes a new instance of the class for an <see cref="UInt32" />
        /// identifier.
        /// </summary>
        /// <param name="identifier">
        /// An <see cref="UInt32" /> identifier to be represented by the instance.
        /// </param>
        public EntityIdentifier(uint identifier)
            : this(identifier.ToString(CultureInfo.InvariantCulture))
        { }

        /// <summary>
        /// Initializes a new instance of the class for an <see cref="UInt64" />
        /// identifier.
        /// </summary>
        /// <param name="identifier">
        /// An <see cref="UInt64" /> identifier to be represented by the instance.
        /// </param>
        public EntityIdentifier(ulong identifier)
            : this(identifier.ToString(CultureInfo.InvariantCulture))
        { }

        /// <summary>
        /// Gets a case-insensitive string representation of the identifier.
        /// </summary>
        public string Identifier
        {
            get { return this.identifier; }
        }

        /// <summary>
        /// Returns the hash code for the identifier.
        /// </summary>
        /// <returns>The hash code for the identifier.</returns>
        public override int GetHashCode()
        {
            return this.identifier.ToUpper().GetHashCode();
        }

        /// <summary>
        /// Returns a value indicating whether the current instance and the specified
        /// object (provided it's also an <see cref="EntityIdentifier" /> instance)
        /// represent the same identifier.
        /// </summary>
        /// <param name="obj">The object to compare the current instance to.</param>
        /// <returns>
        /// True, if the specified object and the current instance represent the same
        /// identifier; otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            bool equals = false;
            if(obj is EntityIdentifier identifier)
            {
                equals = this.identifier.Equals(
                    identifier.identifier,
                    StringComparison.InvariantCultureIgnoreCase);
            }
            return equals;
        }

        /// <summary>
        /// Returns a string representation of the identifier.
        /// </summary>
        /// <returns>A string representation of the identifier.</returns>
        public override string ToString()
        {
            return this.identifier;
        }
    }
}
