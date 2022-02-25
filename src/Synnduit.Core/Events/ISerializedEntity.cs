namespace Synnduit.Events
{
    /// <summary>
    /// Exposes serialized-entity-related information.
    /// </summary>
    public interface ISerializedEntity
    {
        /// <summary>
        /// Gets the hash of the serialized entity data.
        /// </summary>
        string DataHash { get; }

        /// <summary>
        /// Gets the serialized entity as a byte array.
        /// </summary>
        byte[] Data { get; }

        /// <summary>
        /// Gets the entity label (i.e., name or short description).
        /// </summary>
        string Label { get; }
    }
}
