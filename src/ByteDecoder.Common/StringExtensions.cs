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
            return double.Parse(source, NumberFormatInfo.CurrentInfo);
        }
    }
}
