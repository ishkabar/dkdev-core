// Extensions/StringExtensions.cs
namespace DKDev.Extensions;

/// <summary>
/// Extension methods for <see cref="string"/>.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Determines whether the string is null or empty.
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <returns><c>true</c> if the string is null or empty; otherwise <c>false</c>.</returns>
    public static bool IsNullOrEmpty(this string? value)
        => string.IsNullOrEmpty(value);

    /// <summary>
    /// Determines whether the string is null, empty, or consists only of white-space characters.
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <returns><c>true</c> if the string is null, empty, or whitespace; otherwise <c>false</c>.</returns>
    public static bool IsNullOrWhiteSpace(this string? value)
        => string.IsNullOrWhiteSpace(value);

    /// <summary>
    /// Determines whether the string has a meaningful value (not null, empty, or whitespace).
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <returns><c>true</c> if the string has a value; otherwise <c>false</c>.</returns>
    public static bool HasValue(this string? value)
        => !string.IsNullOrWhiteSpace(value);

    /// <summary>
    /// Truncates the string to the specified maximum length.
    /// </summary>
    /// <param name="value">The string to truncate.</param>
    /// <param name="maxLength">The maximum length.</param>
    /// <param name="suffix">Optional suffix to append when truncated (default is "...").</param>
    /// <returns>The truncated string.</returns>
    public static string Truncate(this string? value, int maxLength, string suffix = "...")
    {
        if (value.IsNullOrEmpty() || value!.Length <= maxLength)
            return value ?? string.Empty;

        var truncateLength = maxLength - suffix.Length;
        return truncateLength > 0
            ? value.Substring(0, truncateLength) + suffix
            : value.Substring(0, maxLength);
    }

    /// <summary>
    /// Ensures the string ends with the specified suffix.
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <param name="suffix">The required suffix.</param>
    /// <returns>The string with the suffix appended if needed.</returns>
    public static string EnsureEndsWith(this string? value, string suffix)
    {
        if (value.IsNullOrEmpty())
            return suffix;

        return value!.EndsWith(suffix, StringComparison.Ordinal)
            ? value
            : value + suffix;
    }

    /// <summary>
    /// Ensures the string starts with the specified prefix.
    /// </summary>
    /// <param name="value">The string to check.</param>
    /// <param name="prefix">The required prefix.</param>
    /// <returns>The string with the prefix prepended if needed.</returns>
    public static string EnsureStartsWith(this string? value, string prefix)
    {
        if (value.IsNullOrEmpty())
            return prefix;

        return value!.StartsWith(prefix, StringComparison.Ordinal)
            ? value
            : prefix + value;
    }
}