namespace Synnduit
{
    /// <summary>
    /// Defines individual behaviors that govern how orphan identifier mappings (i.e.,
    /// those whose source system entity no longer exists in its respective external
    /// system) are dealt with.
    /// </summary>
    public enum OrphanMappingBehavior
    {
        /// <summary>
        /// No action is taken; orphan mappings remain active.
        /// </summary>
        None = 1,

        /// <summary>
        /// Orphan mappings will be deactivated, but not removed.
        /// </summary>
        Deactivate,

        /// <summary>
        /// Orphan mappings will be removed.
        /// </summary>
        Remove
    }
}
