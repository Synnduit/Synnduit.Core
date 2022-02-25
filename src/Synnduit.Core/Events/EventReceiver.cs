using System;

namespace Synnduit.Events
{
    /// <summary>
    /// A default implementation of the <see cref="IEventReceiver{TEventArgs}" />
    /// interface for each event type; allows derived classes to override methods
    /// representing events they wish to handle.
    /// </summary>
    /// <typeparam name="TEntity">The type representing the entity.</typeparam>
    public abstract class EventReceiver<TEntity> :
        IEntityTypeEventReceiver<TEntity>,
        IEventReceiver<ICachePopulatedArgs>,
        IEventReceiver<ICachePopulatingArgs>,
        IEventReceiver<IDeletionEntityLoadedArgs<TEntity>>,
        IEventReceiver<IDeletionProcessedArgs>,
        IEventReceiver<IDeletionProcessingArgs>,
        IEventReceiver<IGarbageCollectionInitializedArgs>,
        IEventReceiver<IGarbageCollectionInitializingArgs>,
        IEventReceiver<IInitializedArgs>,
        IEventReceiver<IInitializingArgs>,
        IEventReceiver<ILoadedArgs>,
        IEventReceiver<ILoadingArgs>,
        IEventReceiver<IMappingsCachedArgs>,
        IEventReceiver<IMappingsCachingArgs>,
        IEventReceiver<IOrphanMappingProcessedArgs>,
        IEventReceiver<IOrphanMappingsProcessingArgs>,
        IEventReceiver<IProcessedArgs<TEntity>>,
        IEventReceiver<IProcessingArgs<TEntity>>,
        IEventReceiver<ISegmentExecutedArgs>,
        IEventReceiver<ISegmentExecutingArgs>
        where TEntity : class
    {
        private readonly Lazy<IContext> context;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        protected EventReceiver()
        {
            this.context = new Lazy<IContext>(
                DependencyContainer.Instance.Get<IContext>);
        }

        /// <summary>
        /// Called when the (deduplication) in-memory cache of destination system entities
        /// has been populated.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnCachePopulated(ICachePopulatedArgs args)
        { }

        /// <summary>
        /// Called when the (deduplication) in-memory cache of destination system entities
        /// is about to be populated.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnCachePopulating(ICachePopulatingArgs args)
        { }

        /// <summary>
        /// Called when a destination system entity identified for deletion has been loaded
        /// from the destination system.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnDeletionEntityLoaded(IDeletionEntityLoadedArgs<TEntity> args)
        { }

        /// <summary>
        /// Called when the deletion of a destination system entity (identified for
        /// deletion) has been processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnDeletionProcessed(IDeletionProcessedArgs args)
        { }

        /// <summary>
        /// Called when the deletion of a destination system entity (identified for
        /// deletion) is about to be processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnDeletionProcessing(IDeletionProcessingArgs args)
        { }

        /// <summary>
        /// Called when a garbage collection run segment has been initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnGarbageCollectionInitialized(
            IGarbageCollectionInitializedArgs args)
        { }

        /// <summary>
        /// Called when a garbage collection run segment has been initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnGarbageCollectionInitializing(
            IGarbageCollectionInitializingArgs args)
        { }

        /// <summary>
        /// Called when a subsystem has been initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnInitialized(IInitializedArgs args)
        { }

        /// <summary>
        /// Called when a subsystem is about to be initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnInitializing(IInitializingArgs args)
        { }

        /// <summary>
        /// Called when entities from a source system have been loaded.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnLoaded(ILoadedArgs args)
        { }

        /// <summary>
        /// Called when entities from a source system feed are about to be loaded.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnLoading(ILoadingArgs args)
        { }

        /// <summary>
        /// Called when source/destination system identifier mappings have been loaded from
        /// the database into the in-memory cache.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnMappingsCached(IMappingsCachedArgs args)
        { }

        /// <summary>
        /// Called when source/destination system identifier mappings are about to be
        /// loaded from the database into the in-memory cache.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnMappingsCaching(IMappingsCachingArgs args)
        { }

        /// <summary>
        /// Called when an orphan identifier mapping has been processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnOrphanMappingProcessed(IOrphanMappingProcessedArgs args)
        { }

        /// <summary>
        /// Called when orphan identifier mappings are about to be processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnOrphanMappingsProcessing(IOrphanMappingsProcessingArgs args)
        { }

        /// <summary>
        /// Called when a source system entity has been processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnProcessed(IProcessedArgs<TEntity> args)
        { }

        /// <summary>
        /// Called when a source system entity is about to be processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnProcessing(IProcessingArgs<TEntity> args)
        { }

        /// <summary>
        /// Called when a run segment has finished executing.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnSegmentExecuted(ISegmentExecutedArgs args)
        { }

        /// <summary>
        /// Called when a run segment is about to be executed.
        /// </summary>
        /// <param name="args">The event data.</param>
        public virtual void OnSegmentExecuting(ISegmentExecutingArgs args)
        { }

        /// <summary>
        /// Gets the <see cref="IContext" /> implementation used by the current instance.
        /// </summary>
        protected IContext Context
        {
            get { return this.context.Value; }
        }

        /// <summary>
        /// Called when the (deduplication) in-memory cache of destination system entities
        /// has been populated.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<ICachePopulatedArgs>.Occurred(ICachePopulatedArgs args)
        {
            this.OnCachePopulated(args);
        }

        /// <summary>
        /// Called when the (deduplication) in-memory cache of destination system entities
        /// is about to be populated.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<ICachePopulatingArgs>.Occurred(ICachePopulatingArgs args)
        {
            this.OnCachePopulating(args);
        }

        /// <summary>
        /// Called when a destination system entity identified for deletion has been loaded
        /// from the destination system.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IDeletionEntityLoadedArgs<TEntity>>.Occurred(
            IDeletionEntityLoadedArgs<TEntity> args)
        {
            this.OnDeletionEntityLoaded(args);
        }

        /// <summary>
        /// Called when the deletion of a destination system entity (identified for
        /// deletion) has been processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IDeletionProcessedArgs>.Occurred(IDeletionProcessedArgs args)
        {
            this.OnDeletionProcessed(args);
        }

        /// <summary>
        /// Called when the deletion of a destination system entity (identified for
        /// deletion) is about to be processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IDeletionProcessingArgs>.Occurred(IDeletionProcessingArgs args)
        {
            this.OnDeletionProcessing(args);
        }

        /// <summary>
        /// Called when a garbage collection run segment has been initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IGarbageCollectionInitializedArgs>.Occurred(
            IGarbageCollectionInitializedArgs args)
        {
            this.OnGarbageCollectionInitialized(args);
        }

        /// <summary>
        /// Called when a garbage collection run segment is about to be initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IGarbageCollectionInitializingArgs>.Occurred(
            IGarbageCollectionInitializingArgs args)
        {
            this.OnGarbageCollectionInitializing(args);
        }

        /// <summary>
        /// Called when a subsystem has been initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IInitializedArgs>.Occurred(IInitializedArgs args)
        {
            this.OnInitialized(args);
        }

        /// <summary>
        /// Called when a subsystem is about to be initialized.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IInitializingArgs>.Occurred(IInitializingArgs args)
        {
            this.OnInitializing(args);
        }

        /// <summary>
        /// Called when entities from a source system have been loaded.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<ILoadedArgs>.Occurred(ILoadedArgs args)
        {
            this.OnLoaded(args);
        }

        /// <summary>
        /// Called when entities from a source system feed are about to be loaded.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<ILoadingArgs>.Occurred(ILoadingArgs args)
        {
            this.OnLoading(args);
        }

        /// <summary>
        /// Called when source/destination system identifier mappings have been loaded from
        /// the database into the in-memory cache.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IMappingsCachedArgs>.Occurred(IMappingsCachedArgs args)
        {
            this.OnMappingsCached(args);
        }

        /// <summary>
        /// Called when source/destination system identifier mappings are about to be
        /// loaded from the database into the in-memory cache.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IMappingsCachingArgs>.Occurred(IMappingsCachingArgs args)
        {
            this.OnMappingsCaching(args);
        }

        /// <summary>
        /// Called when an orphan identifier mapping has been processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IOrphanMappingProcessedArgs>.Occurred(
            IOrphanMappingProcessedArgs args)
        {
            this.OnOrphanMappingProcessed(args);
        }

        /// <summary>
        /// Called when orphan identifier mappings are about to be processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IOrphanMappingsProcessingArgs>.Occurred(
            IOrphanMappingsProcessingArgs args)
        {
            this.OnOrphanMappingsProcessing(args);
        }

        /// <summary>
        /// Called when a source system entity has been processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IProcessedArgs<TEntity>>.Occurred(
            IProcessedArgs<TEntity> args)
        {
            this.OnProcessed(args);
        }

        /// <summary>
        /// Called when a source system entity is about to be processed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<IProcessingArgs<TEntity>>.Occurred(
            IProcessingArgs<TEntity> args)
        {
            this.OnProcessing(args);
        }

        /// <summary>
        /// Called when a run segment has finished executing.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<ISegmentExecutedArgs>.Occurred(ISegmentExecutedArgs args)
        {
            this.OnSegmentExecuted(args);
        }

        /// <summary>
        /// Called when a run segment is about to be executed.
        /// </summary>
        /// <param name="args">The event data.</param>
        void IEventReceiver<ISegmentExecutingArgs>.Occurred(ISegmentExecutingArgs args)
        {
            this.OnSegmentExecuting(args);
        }
    }
}
