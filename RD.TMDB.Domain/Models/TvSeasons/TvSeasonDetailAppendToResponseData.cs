using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvShows;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Domain.Models.TvSeasons;

public class TvSeasonDetailAppendToResponseData
{
    [JsonPropertyName("account_states")]
    public Result<TvSeasonAccountState>? AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public Credit<TvCast, TvCrew>? AggregateCredits { get; set; }

    [JsonPropertyName("credits")]
    public Credit<Cast, Crew>? Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalId? ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Image? Images { get; set; }

    [JsonPropertyName("translations")]
    public TranslationContainer<TvSeasonTranslationData>? Translations { get; set; }

    [JsonPropertyName("videos")]
    public Result<Video>? Videos { get; set; }

    [JsonPropertyName("watch/providers")]
    public WatchProviderContainer? WatchProviders { get; set; }
}
