using JetBrains.Annotations;

namespace ByteDecoder.Common.GuardClauses
{
    /// <summary>
    /// Interface for extending the guard clauses using extensions methods.
    /// </summary>
    public interface IGuardClause
    {
        /// <summary>
        /// Guard and check a value if is not null.
        /// </summary>
        /// <typeparam name="T">Generic type for the guard.</typeparam>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        void IfArgumentIsNull<T>([NoEnumeration][ValidatedNotNull] T source, string paramName);

        /// <summary>
        /// Guard and check a value if is not null.
        /// </summary>
        /// <typeparam name="T">Generic type for the guard.</typeparam>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        /// <param name="message">Message if guard clause breaks.</param>
        void IfArgumentIsNull<T>(
            [NoEnumeration][ValidatedNotNull] T source,
            string paramName,
            string message);

        /// <summary>
        /// Guard and check a value if is not null or neither empty.
        /// </summary>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        void IfArgumentIsNullOrEmpty(string? source, string paramName);

        /// <summary>
        /// Guard and check a value if is not null or neither empty.
        /// </summary>
        /// <param name="source">Instance source.</param>
        /// <param name="paramName">Param name.</param>
        /// <param name="message">Message if guard clause breaks.</param>
        void IfArgumentIsNullOrEmpty(string? source, string paramName, string message);

        /// <summary>
        /// Guard and check a value if is in a range.
        /// </summary>
        /// <param name="predicate">Predicate that evaluates the range.</param>
        /// <param name="paramName">Param name.</param>
        /// <param name="message">Message if guard clause breaks.</param>
        void IfArgumentOutOfRange(Func<bool> predicate, string paramName, string message);
    }
}
