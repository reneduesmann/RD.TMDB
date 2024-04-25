using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// File types of an image.
/// </summary>
public enum FileType
{
    /// <summary>
    /// Default value, when no file type is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// File type is svg.
    /// </summary>
    [StringValue(".svg")]
    Svg,

    /// <summary>
    /// File type is png.
    /// </summary>
    [StringValue(".png")]
    Png
}