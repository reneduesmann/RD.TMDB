namespace RD.TMDB.Domain.Models.WatchProviders;

public class WatchProviderContainer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public Dictionary<string, WatchProvider> WatchProviders { get; set; } = [];
}