namespace Synnduit
{
    /// <summary>
    /// To be implemented by classes that need to be invoked during the initialization
    /// process.
    /// </summary>
    public interface IInitializable
    {
        /// <summary>
        /// Initializes the current instance.
        /// </summary>
        /// <param name="context">
        /// The <see cref="IInitializationContext" /> instance to use.
        /// </param>
        void Initialize(IInitializationContext context);
    }
}
