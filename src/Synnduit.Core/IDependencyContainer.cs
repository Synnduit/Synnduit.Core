namespace Synnduit
{
    /// <summary>
    /// Provides access to (system) dependencies that individual base classes make
    /// available to implementers.
    /// </summary>
    /// <remarks>
    /// You may implement this interface to inject alternative (i.e., mock/stub)
    /// dependencies in your unit tests.
    /// </remarks>
    public interface IDependencyContainer
    {
        /// <summary>
        /// Gets a value indicating whether the current instance is a permanent dependency
        /// container.
        /// </summary>
        /// <remarks>
        /// A permanent dependency container can't be replaced; dependency containers used
        /// in unit testing should be non-permanent; the internally used dependency
        /// container is a permanent one.
        /// </remarks>
        bool IsPermanent { get; }

        /// <summary>
        /// Gets the implementation of the specified (interface) type.
        /// </summary>
        /// <typeparam name="T">
        /// The (interface) type whose implementation is requested.
        /// </typeparam>
        /// <returns>The implementation of the specified (interface) type.</returns>
        T Get<T>();
    }
}
