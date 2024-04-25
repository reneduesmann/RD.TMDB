using RD.Extensions.Enums.Attributes;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Genres for movies.
/// </summary>
public enum MovieGenre
{
    /// <summary>
    /// Default value, when no movie genre is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Movie genre is Action.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Action")]
    Action = 28,

    /// <summary>
    /// Movie genre is Adventure.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Abenteuer")]
    Adventure = 12,

    /// <summary>
    /// Movie genre is Animation.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Animation")]
    Animation = 16,

    /// <summary>
    /// Movie genre is Comedy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Komödie")]
    Comedy = 35,

    /// <summary>
    /// Movie genre is Crime.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Krimi")]
    Crime = 80,

    /// <summary>
    /// Movie genre is Documentary.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dokumentarfilm")]
    Documentary = 99,

    /// <summary>
    /// Movie genre is Drama.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Drama")]
    Drama = 18,

    /// <summary>
    /// Movie genre is Family.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Familie")]
    Family = 10751,

    /// <summary>
    /// Movie genre is Fantasy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Fantasy")]
    Fantasy = 14,

    /// <summary>
    /// Movie genre is History.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Historie")]
    History = 36,

    /// <summary>
    /// Movie genre is Horror.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Horror")]
    Horror = 27,

    /// <summary>
    /// Movie genre is Music.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Musik")]
    Music = 10402,

    /// <summary>
    /// Movie genre is Mystery.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mystery")]
    Mystery = 9648,

    /// <summary>
    /// Movie genre is Romance.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Liebesfilm")]
    Romance = 10749,

    /// <summary>
    /// Movie genre is Science_Fiction.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Science Fiction")]
    Science_Fiction = 878,

    /// <summary>
    /// Movie genre is TvMovie.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "TV-Film")]
    TvMovie = 10770,

    /// <summary>
    /// Movie genre is Thriller.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Thriller")]
    Thriller = 53,

    /// <summary>
    /// Movie genre is War.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kriegsfilm")]
    War = 10752,

    /// <summary>
    /// Movie genre is Western.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Western")]
    Western = 37
}