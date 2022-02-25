namespace Synnduit
{
    /// <summary>
    /// A safe wrapper around the <see cref="IMetadataProvider{TEntity}" /> implementation;
    /// ensures that data returned by individual methods is (formally) valid (e.g., no null
    /// references returned); makes sure a given instance's identifiers don't change
    /// between calls.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public interface ISafeMetadataProvider<TEntity> : IMetadataProvider<TEntity>
        where TEntity : class
    {
    }
}
