using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class Country
{
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Value { get; set; }
    
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }
    
    [JsonPropertyName("native_name")]
    public string? NativeName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}