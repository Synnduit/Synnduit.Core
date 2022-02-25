namespace Synnduit
{
    /// <summary>
    /// To be implemented and by classes that define entity types.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface IEntityTypeDefinition<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Creates the definition of the entity type represented by the current instance.
        /// </summary>
        /// <param name="context">
        /// The <see cref="IEntityTypeDefinitionContext{TEntity}" /> instance to use.
        /// </param>
        void Define(IEntityTypeDefinitionContext<TEntity> context);
    }
}
