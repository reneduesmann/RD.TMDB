using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Sizes of a poster.
/// </summary>
public enum PosterSize
{
    /// <summary>
    /// Default value, when no size is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Poster size is W92.
    /// </summary>
    [StringValue("w92")]
    W92,

    /// <summary>
    /// Poster size is W154.
    /// </summary>
    [StringValue("w154")]
    W154,

    /// <summary>
    /// Poster size is W185.
    /// </summary>
    [StringValue("w185")]
    W185,

    /// <summary>
    /// Poster size is W342.
    /// </summary>
    [StringValue("w342")]
    W342,

    /// <summary>
    /// Poster size is W500.
    /// </summary>
    [StringValue("w500")]
    W500,

    /// <summary>
    /// Poster size is W780.
    /// </summary>
    [StringValue("w780")]
    W780,

    /// <summary>
    /// Poster size is Original.
    /// </summary>
    [StringValue("original")]
    Original
}