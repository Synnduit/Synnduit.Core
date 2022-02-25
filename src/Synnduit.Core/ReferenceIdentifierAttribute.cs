using System;

namespace Synnduit
{
    /// <summary>
    /// Used to denote those properties of individual entity classes that represent the
    /// destination system ID of an instance's referenced entity.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        Inherited = true,
        AllowMultiple = false)]
    public sealed class ReferenceIdentifierAttribute : Attribute
    {
        private readonly Type referencedEntityType;

        private readonly string referenceIdentifierPropertyName;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="referencedEntityType">The referenced entity type.</param>
        /// <param name="referenceIdentifierPropertyName">
        /// The name of the property that represents the identifier of the referenced
        /// entity in the source system.
        /// </param>
        public ReferenceIdentifierAttribute(
            Type referencedEntityType, string referenceIdentifierPropertyName)
        {
            ArgumentValidator.EnsureArgumentNotNull(
                referencedEntityType, nameof(referencedEntityType));
            ArgumentValidator.EnsureArgumentNotNullOrWhiteSpace(
                referenceIdentifierPropertyName, nameof(referenceIdentifierPropertyName));
            this.referencedEntityType = referencedEntityType;
            this.referenceIdentifierPropertyName = referenceIdentifierPropertyName;
            this.IsMutable = true;
            this.IsRequiredOnCreation = true;
            this.IsRequiredOnUpdate = true;
        }

        /// <summary>
        /// Gets the referenced entity type.
        /// </summary>
        public Type ReferencedEntityType
        {
            get { return this.referencedEntityType; }
        }

        /// <summary>
        /// Gets the name of the property that represents the identifier of the referenced
        /// entity in the source system.
        /// </summary>
        public string ReferenceIdentifierPropertyName
        {
            get { return this.referenceIdentifierPropertyName; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the value is mutable: i.e., whether or
        /// not it can change during an update operation; the default is True.
        /// </summary>
        public bool IsMutable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the reference identifier is required
        /// when a new entity is being created; the default is True.
        /// </summary>
        /// <remarks>
        /// If a value is required, and the value of the property identified by
        /// ReferencedIdentifierPropertyName is not null, the entity will be rejected.
        /// </remarks>
        public bool IsRequiredOnCreation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the reference identifier is required
        /// when an existing entity is being updated; the default is True; this value will
        /// be ignored, if IsMutable is False.
        /// </summary>
        /// <remarks>
        /// If a value is required, and the value of the property identified by
        /// ReferencedIdentifierPropertyName is not null, the entity will be rejected.
        /// </remarks>
        public bool IsRequiredOnUpdate { get; set; }
    }
}
