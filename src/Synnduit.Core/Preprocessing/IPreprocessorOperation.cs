namespace Synnduit.Preprocessing
{
    /// <summary>
    /// To be implemented by individual preprocessor operations.
    /// </summary>
    public interface IPreprocessorOperation<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Applies the preprocessor operation to the specified entity.
        /// </summary>
        /// <param name="entity">The entity that's being preprocessed.</param>
        void Preprocess(IPreprocessorEntity<TEntity> entity);
    }
}
