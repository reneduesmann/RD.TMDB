using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.TvShows;

public class TvShowTranslationData : TranslationData
{
    [JsonPropertyName("tagline")]
    public string? Tagline { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
