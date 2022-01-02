using JetBrains.Annotations;

namespace ByteDecoder.Common.GuardClauses
{
    /// <summary>
    /// Guard singleton class.
    /// </summary>
    public class Guard : IGuardClause
    {
        private Guard() { }

        /// <summary>
        /// Gets the Guard instance.
        /// </summary>
        /// <returns>Guard extension methods.</returns>
        public static IGuardClause Break { get; } = new Guard();

        /// <summary>
        /// Guard and check a value if is not null.
        /// </summary>
        /// <typeparam name="T">Generic type for the guard.</typeparam>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        public void IfArgumentIsNull<T>([NoEnumeration][ValidatedNotNull] T source, string paramName)
        {
            if (source == null)
                throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Guard and check a value if is not null.
        /// </summary>
        /// <typeparam name="T">Generic type for the guard.</typeparam>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        /// <param name="message">Message if guard clause breaks.</param>
        public void IfArgumentIsNull<T>(
            [NoEnumeration][ValidatedNotNull] T source,
            string paramName,
            string message)
        {
            if (source == null)
                throw new ArgumentNullException(paramName, message);
        }

        /// <summary>
        /// Guard and check a value if is not null or neither empty.
        /// </summary>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        public void IfArgumentIsNullOrEmpty(string? source, string paramName)
        {
            if (string.IsNullOrEmpty(source))
                throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Guard and check a value if is not null or neither empty.
        /// </summary>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        /// <param name="message">Message if guard clause breaks.</param>
        public void IfArgumentIsNullOrEmpty(string? source, string paramName, string message)
        {
            if (string.IsNullOrEmpty(source))
                throw new ArgumentNullException(paramName, message);
        }

        /// <summary>
        /// Guard and check a value if is in a range.
        /// </summary>
        /// <param name="predicate">Predicate that evaluates the range.</param>
        /// <param name="paramName">Param name.</param>
        /// <param name="message">Message if guard clause breaks.</param>
        public void IfArgumentOutOfRange(Func<bool> predicate, string paramName, string message)
        {
            IfArgumentIsNull(predicate, nameof(predicate));

            if (predicate())
                throw new ArgumentOutOfRangeException(paramName, message);
        }
    }
}
