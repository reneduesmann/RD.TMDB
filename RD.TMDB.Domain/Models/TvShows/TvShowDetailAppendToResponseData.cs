using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.AlternativeTitles;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Reviews;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvSeasons;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Domain.Models.TvShows;

public class TvShowDetailAppendToResponseData
{
    [JsonPropertyName("account_states")]
    public AccountState? AccountState { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public Credit<TvCast, TvCrew>? AggregateCredits { get; set; }

    [JsonPropertyName("alternative_titles")]
    public Result<AlternativeTitle>? AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public Changes.ChangeContainer? Changes { get; set; }

    [JsonPropertyName("content_ratings")]
    public Result<ContentRating>? ContentRatings { get; set; }

    [JsonPropertyName("credits")]
    public Credit<Cast, Crew>? Credits { get; set; }

    [JsonPropertyName("episode_groups")]
    public Result<TvEpisodeGroup>? EpisodeGroups { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalId? ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Image? Images { get; set; }

    [JsonPropertyName("keywords")]
    public Result<Keyword>? Keywords { get; set; }

    [JsonPropertyName("lists")]
    public ResultContainer<List>? Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public ResultContainer<TvShow>? Recommendations { get; set; }

    [JsonPropertyName("reviews")]
    public ResultContainer<Review>? Reviews { get; set; }

    [JsonPropertyName("screened_theatrically")]
    public Result<ScreenedTheatrically>? ScreenedTheatrically { get; set; }

    [JsonPropertyName("similar")]
    public ResultContainer<TvShow>? SimilarTvShows { get; set; }

    [JsonPropertyName("translations")]
    public TranslationContainer<TvShowTranslationData>? Translations { get; set; }

    [JsonPropertyName("videos")]
    public Result<Video>? Videos { get; set; }

    [JsonPropertyName("watch/providers")]
    public WatchProviderContainer? WatchProviders { get; set; }

    [JsonIgnore]
    public Dictionary<string, TvSeasonDetail> TvSeasonEpisodes { get; set; } = [];
}
