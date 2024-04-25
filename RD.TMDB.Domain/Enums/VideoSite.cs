using RD.Extensions.Enums.Attributes;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Sites on where videos are available.
/// </summary>
public enum VideoSite
{
    /// <summary>
    /// Default value, when the video site is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Video site is youtube.
    /// </summary>
    [KeyValuePair(VideoSiteKey, "https://www.youtube.com/watch?v={0}")]
    [StringValue("YouTube")]
    Youtube
}