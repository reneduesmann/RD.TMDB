using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.AlternativeTitles;

public class AlternativeTitle
{
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
