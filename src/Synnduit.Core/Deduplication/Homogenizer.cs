namespace Synnduit.Deduplication
{
    /// <summary>
    /// The base class for type-specific homogenizers.
    /// </summary>
    /// <typeparam name="TValue">The supported value type.</typeparam>
    public abstract class Homogenizer<TValue> : IHomogenizer
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        protected Homogenizer()
        { }

        /// <summary>
        /// Homogenizes the specified value.
        /// </summary>
        /// <param name="value">The value to homogenize.</param>
        /// <returns>The homogenized value.</returns>
        public object Homogenize(object value)
        {
            object homogenizedValue;
            if (value is TValue typedValue)
            {
                homogenizedValue = this.Homogenize(typedValue);
            }
            else
            {
                homogenizedValue = value;
            }
            return homogenizedValue;
        }

        /// <summary>
        /// When overiden in a derived class, homogenizes the specified value.
        /// </summary>
        /// <param name="value">The value to homogenize.</param>
        /// <returns>The homogenized value.</returns>
        protected abstract object Homogenize(TValue value);
    }
}
