using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Sizes of a logo.
/// </summary>
public enum LogoSize
{
    /// <summary>
    /// Default value, when no size is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Logo size is W45.
    /// </summary>
    [StringValue("w45")]
    W45,

    /// <summary>
    /// Logo size is W92.
    /// </summary>
    [StringValue("w92")]
    W92,

    /// <summary>
    /// Logo size is W154.
    /// </summary>
    [StringValue("w154")]
    W154,

    /// <summary>
    /// Logo size is W185.
    /// </summary>
    [StringValue("w185")]
    W185,

    /// <summary>
    /// Logo size is W300.
    /// </summary>
    [StringValue("w300")]
    W300,

    /// <summary>
    /// Logo size is W500.
    /// </summary>
    [StringValue("w500")]
    W500,

    /// <summary>
    /// Logo size is Original.
    /// </summary>
    [StringValue("original")]
    Original
}