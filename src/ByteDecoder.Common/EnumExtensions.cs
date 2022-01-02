namespace ByteDecoder.Common;

/// <summary>
/// Enum type extensions.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Converts a string value to an Enum value.
    /// </summary>
    /// <typeparam name="T">Enum type.</typeparam>
    /// <param name="value">Value to convert.</param>
    /// <returns>Enum value.</returns>
    public static T ToEnum<T>(this string value) where T : struct
    {
        return (T)Enum.Parse(typeof(T), value, true);
    }

    /// <summary>
    /// Converts a string value to an Enum value, if fails returns the default value
    /// specified.
    /// </summary>
    /// <typeparam name="T">Enum type.</typeparam>
    /// <param name="value">Value to convert.</param>
    /// <param name="defaultValue">Default enum value.</param>
    /// <returns>Enum value.</returns>
    public static T ToEnum<T>(this string value, T defaultValue) where T : struct
    {
        if (string.IsNullOrWhiteSpace(value))
            return defaultValue;

        T result;
        return Enum.TryParse<T>(value, true, out result) ? result : defaultValue;
    }
}
