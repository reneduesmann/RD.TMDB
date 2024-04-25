using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Domain.Models.Persons;

public class PersonTranslationData : TranslationData
{
    [JsonPropertyName("biography")]
    public string? Biography { get; set; }
}
