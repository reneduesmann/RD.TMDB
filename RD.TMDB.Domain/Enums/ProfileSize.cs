using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Sizes of a profile.
/// </summary>
public enum ProfileSize
{
    /// <summary>
    /// Default value, when no size is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Profile size is W45.
    /// </summary>
    [StringValue("w45")]
    W45,

    /// <summary>
    /// Profile size is W185.
    /// </summary>
    [StringValue("w185")]
    W185,

    /// <summary>
    /// Profile size is H632.
    /// </summary>
    [StringValue("h632")]
    H632,

    /// <summary>
    /// Profile size is Original.
    /// </summary>
    [StringValue("original")]
    Original
}