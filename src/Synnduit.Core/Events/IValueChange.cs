namespace Synnduit.Events
{
    /// <summary>
    /// Represents a single value change performed during a merge.
    /// </summary>
    public interface IValueChange
    {
        /// <summary>
        /// Gets the name of the value that was changed.
        /// </summary>
        string ValueName { get; }

        /// <summary>
        /// Gets the value before the change was applied.
        /// </summary>
        object PreviousValue { get; }

        /// <summary>
        /// Gets the value after the change was applied.
        /// </summary>
        object NewValue { get; }
    }
}
