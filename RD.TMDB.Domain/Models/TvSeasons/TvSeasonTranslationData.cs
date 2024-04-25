using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.TvSeasons;

public class TvSeasonTranslationData : TranslationData
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
