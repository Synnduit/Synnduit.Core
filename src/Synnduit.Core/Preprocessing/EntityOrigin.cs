namespace Synnduit.Preprocessing
{
    /// <summary>
    /// Represents possible origins of an entity about to be preprocessed.
    /// </summary>
    public enum EntityOrigin
    {
        /// <summary>
        /// The entity originated in a source system.
        /// </summary>
        SourceSystem = 1,

        /// <summary>
        /// The entity originated in the destination system.
        /// </summary>
        DestinationSystem = 2
    }
}
