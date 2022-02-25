namespace Synnduit.Deduplication
{
    /// <summary>
    /// Used to homogenize individual property values in deduplication; this might, for
    /// instance, involve trimming the time of day component of each DateTime value, if
    /// only the date is relevant in deduplication comparisons.
    /// </summary>
    public interface IHomogenizer
    {
        /// <summary>
        /// Homogenizes the specified value.
        /// </summary>
        /// <param name="value">The value to homogenize.</param>
        /// <returns>The homogenized value.</returns>
        /// <remarks>
        /// If a given implementation doesn't recognize the specified value (as it, for
        /// instance, only recognizes strings, and the specified value is an integer),
        /// it must simply return it without changing it.
        /// </remarks>
        object Homogenize(object value);
    }
}
