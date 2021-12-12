namespace InCube.Core;

/// <summary>
/// A collection of extension methods aimed at <see cref="string" />s.
/// </summary>
[PublicAPI]
public static class Strings
{
    /// <summary>
    /// Returns the <paramref name="alternative" /> in case <paramref name="self" /> is null or white space.
    /// </summary>
    /// <param name="self">The string to replace with an alternative in case it is null or white space.</param>
    /// <param name="alternative">
    /// The alternative to use as replacement in case <paramref name="self" /> is null or white
    /// space.
    /// </param>
    /// <returns>A nullable <see cref="string" />.</returns>
    public static string? OrElseIfNullOrWhiteSpace(this string? self, string? alternative) => string.IsNullOrWhiteSpace(self) ? alternative : self;

    /// <summary>
    /// Flattens white space and empty strings to null.
    /// </summary>
    /// <param name="self">The string to de-default.</param>
    /// <returns>A nullable string.</returns>
    public static string? DeDefault(this string? self) => string.IsNullOrWhiteSpace(self) ? null : self;
}