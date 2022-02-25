using System;
using System.Linq.Expressions;

namespace Synnduit
{
    /// <summary>
    /// Exposes entity type definition-related functionality.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IEntityTypeDefinitionContext<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Defines the property that represents the ID that uniquely identifies an entity
        /// in the source system.
        /// </summary>
        /// <typeparam name="TValue">The identifier value type.</typeparam>
        /// <param name="propertyExpression">
        /// The lambda expression specifying the property.
        /// </param>
        /// <seealso cref="SourceSystemIdentifierAttribute" />
        void SourceSystemIdentifier<TValue>(
            Expression<Func<TEntity, TValue>> propertyExpression);

        /// <summary>
        /// Defines the property that represents the ID that uniquely identifies an entity
        /// in the destination system.
        /// </summary>
        /// <typeparam name="TValue">The identifier value type.</typeparam>
        /// <param name="propertyExpression">
        /// The lambda expression specifying the property.
        /// </param>
        /// <seealso cref="DestinationSystemIdentifierAttribute" />
        void DestinationSystemIdentifier<TValue>(
            Expression<Func<TEntity, TValue>> propertyExpression);

        /// <summary>
        /// Defines an entity property.
        /// </summary>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="propertyExpression">
        /// The lambda expression specifying the property.
        /// </param>
        /// <param name="groupName">
        /// The name of the group that the value belongs to; groups of values are treated
        /// atomically: i.e., if any one value from a group is modified, all properties
        /// belonging to the group are considered modified and are marked for propagation.
        /// </param>
        /// <param name="nullifyIfWhiteSpaceOnly">
        /// A value indicating whether the value should be set to null if it consists
        /// exclusively of white space characters; only applicable to strings.
        /// </param>
        /// <param name="ignoreTrailingWhiteSpace">
        /// A value indicating whether trailing white space characters should be ignored
        /// during a merge; only applicable to strings.
        /// </param>
        /// <param name="maxLength">
        /// The maximum length of a string value in characters; only applicable to strings;
        /// a negative value (-1, the default) indicates no restriction.
        /// </param>
        /// <seealso cref="EntityPropertyAttribute" />
        void EntityProperty<TValue>(
            Expression<Func<TEntity, TValue>> propertyExpression,
            string groupName = null,
            bool nullifyIfWhiteSpaceOnly = true,
            bool ignoreTrailingWhiteSpace = false,
            int maxLength = -1);

        /// <summary>
        /// Defines an entity property with a nullable proxy property.
        /// </summary>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="propertyExpression">
        /// The lambda expression specifying the property.
        /// </param>
        /// <param name="nullableProxyPropertyExpression">
        /// The lambda expression specifying the nullable proxy property.
        /// </param>
        /// <param name="groupName">
        /// The name of the group that the value belongs to; groups of values are treated
        /// atomically: i.e., if any one value from a group is modified, all properties
        /// belonging to the group are considered modified and are marked for propagation.
        /// </param>
        /// <param name="maxLength">
        /// The maximum length of a string value in characters; only applicable to strings;
        /// a negative value (-1, the default) indicates no restriction.
        /// </param>
        /// <seealso cref="EntityPropertyAttribute" />
        void EntityProperty<TValue>(
            Expression<Func<TEntity, TValue>> propertyExpression,
            Expression<Func<TEntity, TValue?>> nullableProxyPropertyExpression,
            string groupName = null,
            int maxLength = -1)
            where TValue : struct;

        /// <summary>
        /// Defines a reference entity identifier property.
        /// </summary>
        /// <typeparam name="TDestinationIdentifier">
        /// The destination system identifier type.
        /// </typeparam>
        /// <typeparam name="TSourceIdentifier">
        /// The source system identifier type.
        /// </typeparam>
        /// <param name="destinationIdentifierPropertyExpression">
        /// The lambda expression specifying the property that represents the identifier of
        /// the referenced entity in the destination system.
        /// </param>
        /// <param name="sourceIdentifierPropertyExpression">
        /// The lambda expression specifying the property that represents the identifier of
        /// the referenced entity in the source system.
        /// </param>
        /// <param name="referencedEntityType">The referenced entity type.</param>
        /// <param name="isMutable">
        /// A value indicating whether the value is mutable: i.e., whether or not it can
        /// change during an update operation.
        /// </param>
        /// <param name="isRequiredOnCreation">
        /// A value indicating whether the reference identifier is required when a new
        /// entity is being created
        /// </param>
        /// <param name="isRequiredOnUpdate">
        /// A value indicating whether the reference identifier is required when an
        /// existing entity is being updated; this value will be ignored, if IsMutable is
        /// False.
        /// </param>
        /// <seealso cref="ReferenceIdentifierAttribute" />
        void ReferenceIdentifier<TDestinationIdentifier, TSourceIdentifier>(
            Expression<Func<
                TEntity, TDestinationIdentifier>> destinationIdentifierPropertyExpression,
            Expression<Func<
                TEntity, TSourceIdentifier>> sourceIdentifierPropertyExpression,
            Type referencedEntityType,
            bool isMutable = true,
            bool isRequiredOnCreation = true,
            bool isRequiredOnUpdate = true);

        /// <summary>
        /// Defines a duplication key.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="propertyExpression"></param>
        /// <seealso cref="Deduplication.DuplicationKeyAttribute" />
        void DuplicationKey<TValue>(Expression<Func<TEntity, TValue>> propertyExpression);
    }
}
