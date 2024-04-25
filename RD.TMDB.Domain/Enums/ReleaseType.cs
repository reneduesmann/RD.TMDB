namespace RD.TMDB.Domain.Enums;

public enum ReleaseType
{
    /// <summary>
    /// Default value, when the release type is not existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Release type is premiere.
    /// </summary>
    Premiere = 1,

    /// <summary>
    /// Release type is theatrical limited.
    /// </summary>
    TheatricalLimited = 2,

    /// <summary>
    /// Release type is theatrical.
    /// </summary>
    Theatrical = 3,

    /// <summary>
    /// Release type is digital.
    /// </summary>
    Digital = 4,

    /// <summary>
    /// Release type is physical.
    /// </summary>
    Physical = 5,

    /// <summary>
    /// Release type is tv.
    /// </summary>
    Tv = 6
}