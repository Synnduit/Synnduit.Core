using System;
using Synnduit.Properties;

namespace Synnduit
{
    /// <summary>
    /// Extension methods for the <see cref="IContext" /> interface.
    /// </summary>
    public static class ContextExtensions
    {
        /// <summary>
        /// Gets the specified parameter value converted to the specified enumeration type.
        /// </summary>
        /// <typeparam name="TEnum">The enumeration type.</typeparam>
        /// <param name="context">The context.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <param name="defaultValue">
        /// The default value; will be returned if the specified parameter doesn't exist
        /// (i.e., isn't specified).
        /// </param>
        /// <returns>
        /// The parameter value converted to the specified enumeration type.
        /// </returns>
        public static TEnum GetParameter<TEnum>(
            this IContext context, string parameterName, TEnum defaultValue)
            where TEnum : struct
        {
            TEnum value = defaultValue;
            if(context.Parameters.TryGetValue(parameterName, out string valueAsString))
            {
                if(Enum.TryParse(valueAsString, out value) == false)
                {
                    throw new InvalidOperationException(
                        string.Format(
                            Resources.ParameterCannotBeConvertedToEnum,
                            valueAsString,
                            typeof(TEnum).FullName));
                }
            }
            return value;
        }
    }
}
