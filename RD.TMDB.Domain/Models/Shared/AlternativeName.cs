namespace RD.TMDB.Domain.Models.Shared;

public class AlternativeName
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}