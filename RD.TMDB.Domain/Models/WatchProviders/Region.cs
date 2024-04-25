using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.WatchProviders;

public class Region
{
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }
    
    [JsonPropertyName("native_name")]
    public string? NativeName { get; set; }
}