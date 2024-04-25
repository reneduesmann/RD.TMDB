using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Networks;

public class Network
{
    [JsonPropertyName("headquarters")]
    public string? Headquarters { get; set; }
    
    [JsonPropertyName("homepage")]
    public Uri? Homepage { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("logo_path")]
    public string? LogoPath { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("origin_country")]
    public Iso3166_1 Country { get; set; }
}