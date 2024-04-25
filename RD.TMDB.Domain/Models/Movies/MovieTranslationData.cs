using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.Movies;

public class MovieTranslationData : TranslationData
{
    [JsonPropertyName("tagline")]
    public string? Tagline { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }
}
