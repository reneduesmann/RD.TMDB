using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Sizes of a backdrop.
/// </summary>
public enum BackdropSize
{
    /// <summary>
    /// Default value, when no size is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Backdrop size is W300.
    /// </summary>
    [StringValue("w300")]
    W300,

    /// <summary>
    /// Backdrop size is W780.
    /// </summary>
    [StringValue("w780")]
    W780,

    /// <summary>
    /// Backdrop size is W1280.
    /// </summary>
    [StringValue("w1280")]
    W1280,

    /// <summary>
    /// Backdrop size is Original.
    /// </summary>
    [StringValue("original")]
    Original
}