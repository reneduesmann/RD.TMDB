using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class Language
{
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Value { get; set; }
    
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}