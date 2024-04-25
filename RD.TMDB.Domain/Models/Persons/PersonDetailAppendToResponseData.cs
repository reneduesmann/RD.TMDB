using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.Persons;

public class PersonDetailAppendToResponseData
{
    [JsonPropertyName("changes")]
    public ChangeContainer? Changes { get; set; }

    [JsonPropertyName("combined_credits")]
    public Credit<CombinedCast, CombinedCrew>? CombinedCredits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalId? ExternalId { get; set; }

    [JsonPropertyName("images")]
    public PersonImage? Images { get; set; }

    [JsonPropertyName("movie_credits")]
    public Credit<MovieCast, MovieCrew>? MovieCredits { get; set; }

    [JsonPropertyName("tv_credits")]
    public Credit<TvShowCast, TvShowCrew>? TvShowCredits { get; set; }

    [JsonPropertyName("translations")]
    public TranslationContainer<PersonTranslationData>? Translations { get; set; }
}
