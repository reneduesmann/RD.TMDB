using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

// <summary>
/// Types of a video.
/// </summary>
public enum VideoType
{
    /// <summary>
    /// Default value, when the video type is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Video type is opening credits.
    /// </summary>
    [StringValue("Opening Credits")]
    OpeningCredits,

    /// <summary>
    /// Video type is clip.
    /// </summary>
    [StringValue("Clip")]
    Clip,

    /// <summary>
    /// Video type is trailer.
    /// </summary>
    [StringValue("Trailer")]
    Trailer,

    /// <summary>
    /// Video type is bloopers.
    /// </summary>
    [StringValue("Bloopers")]
    Bloopers,

    /// <summary>
    /// Video type is featurette.
    /// </summary>
    [StringValue("Featurette")]
    Featurette,

    /// <summary>
    /// Video type is recap.
    /// </summary>
    [StringValue("Recap")]
    Recap,

    /// <summary>
    /// Video type is teaser.
    /// </summary>
    [StringValue("Teaser")]
    Teaser
}