namespace ByteDecoder.Common;

/// <summary>
/// Integer math comparision extension methods.
/// </summary>
public static class MathComparisonExtensions
{
    /// <summary>
    /// Integer extension method for Greater Than.
    /// </summary>
    /// <param name="i">Current integer source value.</param>
    /// <param name="value">integer type to compare against it.</param>
    /// <returns>Boolean evaluation result.</returns>
    public static bool IsGreaterThan(this int i, int value) => i > value;

    /// <summary>
    /// Integer extension method for Less Than.
    /// </summary>
    /// <param name="i">Current integer source value.</param>
    /// <param name="value">integer type to compare against it.</param>
    /// <returns>Boolean evaluation result.</returns>
    public static bool IsLessThan(this int i, int value) => i < value;

    /// <summary>
    /// Integer extension method for Equal To.
    /// </summary>
    /// <param name="i">Current integer source value.</param>
    /// <param name="value">integer type to compare against it.</param>
    /// <returns>Boolean evaluation result.</returns>
    public static bool IsEqualTo(this int i, int value) => i == value;

    /// <summary>
    /// Integer extension method for Not Equal To.
    /// </summary>
    /// <param name="i">Current integer source value.</param>
    /// <param name="value">integer type to compare against it.</param>
    /// <returns>Boolean evaluation result.</returns>
    public static bool IsNotEqualTo(this int i, int value) => i != value;

    /// <summary>
    /// Integer extension method for Greater Than Or Equal To.
    /// </summary>
    /// <param name="i">Current integer source value.</param>
    /// <param name="value">integer type to compare against it.</param>
    /// <returns>Boolean evaluation result.</returns>
    public static bool IsGreaterThanOrEqualTo(this int i, int value) => i >= value;

    /// <summary>
    /// Integer extension method for Less Than Or Equal To.
    /// </summary>
    /// <param name="i">Current integer source value.</param>
    /// <param name="value">integer type to compare against it.</param>
    /// <returns>Boolean evaluation result.</returns>
    public static bool IsLessThanOrEqualTo(this int i, int value) => i <= value;
}
