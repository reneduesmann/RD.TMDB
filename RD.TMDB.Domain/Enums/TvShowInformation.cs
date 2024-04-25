namespace RD.TMDB.Domain.Enums;

[Flags]
public enum TvShowInformation
{
    Undefined = 0,

    AccountStates = 1 << 0,

    AggregateCredits = 1 << 1,

    AlternativeTitles = 1 << 2,

    Changes = 1 << 3,

    ContentRatings = 1 << 4,

    Credits = 1 << 5,

    EpisodeGroups = 1 << 6,

    ExternalIds = 1 << 7,

    Images = 1 << 8,

    Keywords = 1 << 9,

    Lists = 1 << 10,

    Recommendations = 1 << 11,

    Reviews = 1 << 12,

    ScreenedTheatrically = 1 << 13,

    SimilarTvShows = 1 << 14,

    Translations = 1 << 15,

    Videos = 1 << 16,

    WatchProviders = 1 << 17
}