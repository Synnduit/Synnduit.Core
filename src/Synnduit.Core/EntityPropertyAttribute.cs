using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote those properties of individual entity classes that will be merged
    /// and propagated into the destination system.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        Inherited = true,
        AllowMultiple = false)]
    public sealed class EntityPropertyAttribute : Attribute
    {
        private readonly string groupName;

        /// <summary>
        /// Initializes a new instance of the class and sets the value of the group that
        /// the value belongs to.
        /// </summary>
        /// <param name="groupName">
        /// The name of the group that the value belongs to; groups of values are treated
        /// atomically: i.e., if any one value from a group is modified, all the properties
        /// belonging to the group are considered modified and are marked for propagation.
        /// </param>
        public EntityPropertyAttribute(string groupName)
        {
            this.groupName = groupName;
            this.NullableProxyProperty = null;
            this.NullifyIfWhiteSpaceOnly = true;
            this.IgnoreTrailingWhiteSpace = false;
        }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EntityPropertyAttribute()
            : this(null)
        { }

        /// <summary>
        /// Gets the name of the group that the value belongs to; groups of values are
        /// treated atomically: i.e., if any one value from a group is modified, all
        /// properties belonging to the group are considered modified and are marked for
        /// propagation.
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
        }

        /// <summary>
        /// Gets or sets the name of the property's nullable proxy property.
        /// </summary>
        public string NullableProxyProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the value should be set to null if it
        /// consists exclusively of white space characters; only applicable to strings; the
        /// default is True.
        /// </summary>
        public bool NullifyIfWhiteSpaceOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether trailing white space characters should
        /// be ignored during a merge; only applicable to strings; the default is False.
        /// </summary>
        public bool IgnoreTrailingWhiteSpace { get; set; }
    }
}
