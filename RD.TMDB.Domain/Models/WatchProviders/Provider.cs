namespace RD.TMDB.Domain.Models.WatchProviders;

public class Provider
{
    [JsonPropertyName("logo_path")]
    public string? LogoPath { get; set; }
    
    [JsonPropertyName("provider_id")]
    public int ProviderId { get; set; }
    
    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; set; }
    
    [JsonPropertyName("display_priority")]
    public int DisplayPriority { get; set; }

    [JsonPropertyName("display_priorities")]
    public Dictionary<string, int> DisplayPriorities { get; set; } = [];
}
