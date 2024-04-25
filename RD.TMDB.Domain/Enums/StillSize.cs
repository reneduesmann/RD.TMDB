using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Sizes of a still.
/// </summary>
public enum StillSize
{
    /// <summary>
    /// Default value, when no size is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Profile size is W92.
    /// </summary>
    [StringValue("w92")]
    W92,

    /// <summary>
    /// Profile size is W185.
    /// </summary>
    [StringValue("w185")]
    W185,

    /// <summary>
    /// Profile size is W300.
    /// </summary>
    [StringValue("w300")]
    W300,

    /// <summary>
    /// Profile size is Original.
    /// </summary>
    [StringValue("original")]
    Original
}