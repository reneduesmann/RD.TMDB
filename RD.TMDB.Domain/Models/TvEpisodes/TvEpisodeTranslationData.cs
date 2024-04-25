using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.TvEpisodes;

public class TvEpisodeTranslationData : TranslationData
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
