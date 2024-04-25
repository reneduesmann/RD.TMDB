namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Types of a tv episode group.
/// </summary>
public enum GroupType
{
    /// <summary>
    /// Default value, when the tv episode group type is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Tv episode group type is original air date.
    /// </summary>
    OriginalAirDate = 1,

    /// <summary>
    /// Tv episode group type is absolute.
    /// </summary>
    Absolute = 2,

    /// <summary>
    /// Tv episode group type is dvd.
    /// </summary>
    DVD = 3,

    /// <summary>
    /// Tv episode group type is digital.
    /// </summary>
    Digital = 4,

    /// <summary>
    /// Tv episode group type is story arc.
    /// </summary>
    StoryArc = 5,

    /// <summary>
    /// Tv episode group type is production.
    /// </summary>
    Production = 6,

    /// <summary>
    /// Tv episode group type is tv.
    /// </summary>
    TV = 7
}