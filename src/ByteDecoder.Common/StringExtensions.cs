using System;
using System.Globalization;

namespace ByteDecoder.Common
{
    /// <summary>
    /// String extensions methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Convert a string to integer type.
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Parse result.</returns>
        public static int ToInt(this string source)
        {
            return int.Parse(source, NumberFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// Convert a string to double type.
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Parse result.</returns>
        public static double ToDouble(this string source)
        {
            try
            {
                return double.Parse(source, NumberFormatInfo.CurrentInfo);
            }
            catch (FormatException)
            {
                return double.NaN;
            }
        }

        /// <summary>
        /// Converts an string into a camelCase representation.
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Camel case string result.</returns>
        public static string ToCamelCase(this string source)
        {
            if (!string.IsNullOrEmpty(source) && source.Length > 1)
            {
                return char.ToLowerInvariant(source[0]) + source.Substring(1);
            }

            return source;
        }
    }
}
