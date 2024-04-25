using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Types of a media item.
/// </summary>
public enum MediaType
{
    /// <summary>
    /// Default value, when the media type is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Media type is movie.
    /// </summary>
    [StringValue("movie")]
    Movie,

    /// <summary>
    /// Media type is person.
    /// </summary>
    [StringValue("person")]
    Person,

    /// <summary>
    /// Media type is tv show.
    /// </summary>
    [StringValue("tvshow")]
    TvShow,

    /// <summary>
    /// Media type is tv.
    /// </summary>
    [StringValue("tv")]
    Tv,

    [StringValue("tv_episode")]
    TvEpisode,

    [StringValue("tv_season")]
    TvSeason
}