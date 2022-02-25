using System;
using Synnduit.Properties;

namespace Synnduit
{
    /// <summary>
    /// Manages the currently used <see cref="IDependencyContainer" /> instance.
    /// </summary>
    public static class DependencyContainer
    {
        private static IDependencyContainer currentContainer = null;

        /// <summary>
        /// Sets the current <see cref="IDependencyContainer" /> instance.
        /// </summary>
        /// <param name="container">
        /// The <see cref="IDependencyContainer" /> to use as the current dependency
        /// container.
        /// </param>
        public static void SetContainer(IDependencyContainer container)
        {
            ArgumentValidator.EnsureArgumentNotNull(container, nameof(container));
            if(currentContainer == null || !currentContainer.IsPermanent)
            {
                currentContainer = new DependencyContainerWrapper(container);
            }
            else
            {
                throw new InvalidOperationException(
                    Resources.PermanentDependencyContainerSet);
            }
        }

        /// <summary>
        /// Gets the current <see cref="IDependencyContainer" /> instance.
        /// </summary>
        internal static IDependencyContainer Instance
        {
            get
            {
                if(currentContainer == null)
                {
                    throw new InvalidOperationException(
                        Resources.DependencyContainerNotSet);
                }
                return currentContainer;
            }
        }

        private class DependencyContainerWrapper : IDependencyContainer
        {
            private readonly IDependencyContainer container;

            public DependencyContainerWrapper(IDependencyContainer container)
            {
                this.container = container;
            }

            public bool IsPermanent
            {
                get
                {
                    return this.Execute(() => this.container.IsPermanent);
                }
            }

            public T Get<T>()
            {
                T dependency = this.Execute(() => this.container.Get<T>());
                if(dependency == null)
                {
                    throw new InvalidOperationException(
                        Resources.DependencyContainerReturnedNull);
                }
                return dependency;
            }

            private T Execute<T>(Func<T> method)
            {
                try
                {
                    return method();
                }
                catch(Exception exception)
                {
                    throw new InvalidOperationException(
                        Resources.DependencyContainerThrewException, exception);
                }
            }
        }
    }
}
