using RD.Extensions.Enums.Attributes;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Genres for tv shows.
/// </summary>
public enum TvShowGenre
{
    /// <summary>
    /// Default value, when no tv show genre is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Tv show genre is Action_Adventure.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Action & Adventure")]
    Action_Adventure = 10759,

    /// <summary>
    /// Tv show genre is Animation.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Animation")]
    Animation = 16,

    /// <summary>
    /// Tv show genre is Comedy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Komödie")]
    Comedy = 35,

    /// <summary>
    /// Tv show genre is Crime.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Krimi")]
    Crime = 80,

    /// <summary>
    /// Tv show genre is Documentary.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dokumentarfilm")]
    Documentary = 99,

    /// <summary>
    /// Tv show genre is Drama.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Drama")]
    Drama = 18,

    /// <summary>
    /// Tv show genre is Family.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Familie")]
    Family = 10751,

    /// <summary>
    /// Tv show genre is Kids.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kids")]
    Kids = 10762,

    /// <summary>
    /// Tv show genre is Mystery.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mystery")]
    Mystery = 9648,

    /// <summary>
    /// Tv show genre is News.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "News")]
    News = 10763,

    /// <summary>
    /// Tv show genre is Reality.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Reality")]
    Reality = 10764,

    /// <summary>
    /// Tv show genre is SciFi_Fantasy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sci-Fi & Fantasy")]
    SciFi_Fantasy = 10765,

    /// <summary>
    /// Tv show genre is Soap.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Soap")]
    Soap = 10766,

    /// <summary>
    /// Tv show genre is Talk.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Talk")]
    Talk = 10767,

    /// <summary>
    /// Tv show genre is War_Politics.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "War & Politics")]
    War_Politics = 10768,

    /// <summary>
    /// Tv show genre is Western.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Western")]
    Western = 37
}