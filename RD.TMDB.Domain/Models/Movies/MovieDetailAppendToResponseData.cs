using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.AlternativeTitles;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Reviews;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Domain.Models.Movies;

public class MovieDetailAppendToResponseData
{
    [JsonPropertyName("account_states")]
    public AccountState? AccountState { get; set; }

    [JsonPropertyName("alternative_titles")]
    public AlternativeTitleContainer? AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public ChangeContainer? ChangeContainer { get; set; }

    [JsonPropertyName("credits")]
    public Credit<Cast, Crew>? Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalId? ExternalId { get; set; }

    [JsonPropertyName("keywords")]
    public KeywordContainer? Keywords { get; set; }

    [JsonPropertyName("lists")]
    public ResultContainer<List>? Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public ResultContainer<Movie>? Recommendations { get; set; }

    [JsonPropertyName("release_dates")]
    public Result<ReleaseDateContainer>? ReleaseDates { get; set; }

    [JsonPropertyName("reviews")]
    public ResultContainer<Review>? Reviews { get; set; }

    [JsonPropertyName("similar")]
    public ResultContainer<Movie>? SimilarMovies { get; set; }

    [JsonPropertyName("translations")]
    public TranslationContainer<MovieTranslationData>? Translations { get; set; }

    [JsonPropertyName("videos")]
    public Result<Video>? Videos { get; set; }

    [JsonPropertyName("images")]
    public Image? Images { get; set; }

    [JsonPropertyName("watch/providers")]
    public WatchProviderContainer? WatchProviders { get; set; }
}
