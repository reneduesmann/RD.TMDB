using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

public enum ChangeKey
{
    Undefined = 0,

    [StringValue("adult")]
    Adult,

    [StringValue("air_date")]
    AirDate,

    [StringValue("also_known_as")]
    AlsoKnownAs,

    [StringValue("alternative_titles")]
    AlternativeTitles,

    [StringValue("biography")]
    Biography,

    [StringValue("birthday")]
    Birthday,

    [StringValue("budget")]
    Budget,

    [StringValue("cast")]
    Cast,

    [StringValue("certifications")]
    Certifications,

    [StringValue("character_names")]
    CharacterNames,

    [StringValue("created_by")]
    CreatedBy,

    [StringValue("crew")]
    Crew,

    [StringValue("deathday")]
    Deathday,

    [StringValue("episode")]
    Episode,

    [StringValue("episode_number")]
    EpisodeNumber,

    [StringValue("episode_run_time")]
    EpisodeRunTime,

    [StringValue("freebase_id")]
    FreebaseId,

    [StringValue("freebase_mid")]
    FreebaseMid,

    [StringValue("general")]
    General,

    [StringValue("genres")]
    Genres,

    [StringValue("guest_stars")]
    GuestStars,

    [StringValue("homepage")]
    Homepage,

    [StringValue("images")]
    Images,

    [StringValue("imdb_id")]
    ImdbId,

    [StringValue("languages")]
    Languages,

    [StringValue("name")]
    Name,

    [StringValue("network")]
    Network,

    [StringValue("origin_country")]
    OriginCountry,

    [StringValue("original_name")]
    OriginalName,

    [StringValue("original_title")]
    OriginalTitle,

    [StringValue("overview")]
    Overview,

    [StringValue("parts")]
    Parts,

    [StringValue("place_of_birth")]
    PlaceOfBirth,

    [StringValue("plot_keywords")]
    PlotKeywords,

    [StringValue("production_code")]
    ProductionCode,

    [StringValue("production_companies")]
    ProductionCompanies,

    [StringValue("production_countries")]
    ProductionCountries,

    [StringValue("releases")]
    Releases,

    [StringValue("release_dates")]
    ReleaseDates,

    [StringValue("revenue")]
    Revenue,

    [StringValue("runtime")]
    Runtime,

    [StringValue("season")]
    Season,

    [StringValue("season_number")]
    SeasonNumber,

    [StringValue("season_regular")]
    SeasonRegular,

    [StringValue("spoken_languages")]
    SpokenLanguages,

    [StringValue("status")]
    Status,

    [StringValue("tagline")]
    Tagline,

    [StringValue("title")]
    Title,

    [StringValue("translations")]
    Translations,

    [StringValue("tvdb_id")]
    TvdbId,

    [StringValue("tvrage_id")]
    TvrageId,

    [StringValue("type")]
    Type,

    [StringValue("video")]
    Video,

    [StringValue("videos")]
    Videos
}