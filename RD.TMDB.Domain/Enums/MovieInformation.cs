using RD.Extensions.Enums.Attributes;

namespace RD.TMDB.Domain.Enums;

[Flags]
public enum MovieInformation
{
    Undefined = 0,

    [StringValue("account_states")]
    AccountStates = 1 << 0,

    [StringValue("alternative_titles")]
    AlternativeTitles = 1 << 1,

    [StringValue("changes")]
    Changes = 1 << 2,

    [StringValue("credits")]
    Credits = 1 << 3,

    [StringValue("external_ids")]
    ExternalIds = 1 << 4,

    [StringValue("keywords")]
    Keywords = 1 << 5,

    [StringValue("lists")]
    Lists = 1 << 6,

    [StringValue("recommendations")]
    Recommendations = 1 << 7,

    [StringValue("release_dates")]
    ReleaseDates = 1 << 8,

    [StringValue("reviews")]
    Reviews = 1 << 9,

    [StringValue("similar")]
    SimilarMovies = 1 << 10,

    [StringValue("translations")]
    Translations = 1 << 11,

    [StringValue("videos")]
    Videos = 1 << 12,

    [StringValue("images")]
    Images = 1 << 13,

    [StringValue("watch/providers")]
    WatchProviders = 1 << 14
}