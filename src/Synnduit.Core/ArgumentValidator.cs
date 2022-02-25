using System;
using System.Collections;
using System.Collections.Generic;
using Synnduit.Properties;

namespace Synnduit
{
    /// <summary>
    /// Contains helper methods to facilitate common argument validation operations.
    /// </summary>
    public static class ArgumentValidator
    {
        /// <summary>
        /// Ensures the specified argument is not null, throwing an
        /// <see cref="ArgumentNullException" /> if it is.
        /// </summary>
        /// <param name="argument">The argument (value) to validate.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void EnsureArgumentNotNull(object argument, string paramName)
        {
            if(argument == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// Ensures the specified string argument is not null or white space, throwing an
        /// <see cref="ArgumentNullException" /> if it is null and an
        /// <see cref="ArgumentException" /> if it is white space.
        /// </summary>
        /// <param name="argument">The argument (value) to validate.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void
            EnsureArgumentNotNullOrWhiteSpace(string argument, string paramName)
        {
            EnsureArgumentNotNull(argument, paramName);
            if(string.IsNullOrWhiteSpace(argument))
            {
                throw new ArgumentException(
                    Resources.ArgumentMustNotBeWhiteSpace, paramName);
            }
        }

        /// <summary>
        /// Ensures the specified string argument does not exceed the specified maximum
        /// allowable length, throwing an <see cref="ArgumentException" /> if it does.
        /// </summary>
        /// <param name="argument">The argument (value) to validate.</param>
        /// <param name="maxLength">The maximum allowable length.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void EnsureArgumentDoesNotExceedMaxLength(
            string argument, int maxLength, string paramName)
        {
            if(argument != null && argument.Length > maxLength)
            {
                throw new ArgumentException(
                    string.Format(Resources.ArgumentTooLong, maxLength),
                    paramName);
            }
        }

        /// <summary>
        /// Ensures the specified <see cref="Guid" /> argument is not an empty GUID value,
        /// throwing an <see cref="ArgumentException" /> if it is.
        /// </summary>
        /// <param name="argument">The argument (value) to validate.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void EnsureArgumentNotEmpty(Guid argument, string paramName)
        {
            if(argument == Guid.Empty)
            {
                throw new ArgumentException(
                    Resources.ArgumentMustNotBeEmptyGuid, paramName);
            }
        }

        /// <summary>
        /// Ensures the specified string value represents a valid <see cref="Guid" />,
        /// throwing an <see cref="ArgumentNullException" /> if it's a null reference and
        /// an <see cref="ArgumentException" /> if it doesn't represent a valid
        /// <see cref="Guid" />.
        /// </summary>
        /// <param name="argument">The argument (value) to validate.</param>
        /// <param name="paramName">The name of the parameter.</param>
        /// <returns>The specified value as a <see cref="Guid" />.</returns>
        public static Guid EnsureArgumentValidGuid(string argument, string paramName)
        {
            EnsureArgumentNotNull(argument, paramName);
            if(Guid.TryParse(argument, out Guid guidValue) == false)
            {
                throw new ArgumentException(
                    string.Format(Resources.ArgumentNotGuid, argument),
                    paramName);
            }
            return guidValue;
        }

        /// <summary>
        /// Ensures that none of the arguments in the specified collection is null,
        /// throwing an <see cref="ArgumentNullException" /> if there is such an element.
        /// </summary>
        /// <param name="arguments">
        /// The collection of arguments (values) to validate.
        /// </param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void EnsureArgumentsNotNull(IEnumerable arguments, string paramName)
        {
            foreach(object argument in arguments)
            {
                EnsureArgumentNotNull(argument, paramName);
            }
        }

        /// <summary>
        /// Ensures that none of the arguments in the specified collection is null,
        /// throwing an <see cref="ArgumentNullException" /> if there is such an element,
        /// as well as that each of the arguments is unique, throwing an
        /// <see cref="ArgumentException" /> if there are duplicates.
        /// </summary>
        /// <param name="arguments">
        /// The collection of arguments (values) to validate.
        /// </param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void EnsureArgumentsNotNullAndUnique(
            IEnumerable arguments, string paramName)
        {
            EnsureArgumentNotNull(arguments, paramName);
            var argumentSet = new HashSet<object>();
            foreach(object argument in arguments)
            {
                EnsureArgumentNotNull(argument, paramName);
                if(!argumentSet.Add(argument))
                {
                    throw new ArgumentException(
                        Resources.ArgumentContainsDuplicates, paramName);
                }
            }
        }
    }
}
