using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Types of a list.
/// </summary>
public enum ListType
{
    /// <summary>
    /// Default value, when the list type is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// List type is movie.
    /// </summary>
    [StringValue("movie")]
    Movie
}