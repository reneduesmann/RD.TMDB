using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Accounts;

public class Account
{
    [JsonPropertyName("avatar")]
    public Avatar? Avatar { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("include_adult")]
    public bool IncludeAdult { get; set; }
    
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}