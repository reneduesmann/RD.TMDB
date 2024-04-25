using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.TvEpisodes;

public class TvEpisodeDetailAppendToResponseData
{
    [JsonPropertyName("account_states")]
    public TvEpisodeAccountState? AccountState { get; set; }

    [JsonPropertyName("credits")]
    public Credit? Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalId? ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Image? Images { get; set; }

    [JsonPropertyName("translations")]
    public TranslationContainer<TvEpisodeTranslationData>? Translations { get; set; }

    [JsonPropertyName("videos")]
    public Result<Video>? Videos { get; set; }
}