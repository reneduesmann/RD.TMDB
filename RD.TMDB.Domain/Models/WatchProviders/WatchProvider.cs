namespace RD.TMDB.Domain.Models.WatchProviders;

public class WatchProvider
{
    [JsonPropertyName("link")]
    public Uri? Link { get; set; }

    [JsonPropertyName("buy")]
    public IReadOnlyList<Provider> Buy { get; set; } = [];

    [JsonPropertyName("flatrate")]
    public IReadOnlyList<Provider> Flatrate { get; set; } = [];

    [JsonPropertyName("rent")]
    public IReadOnlyList<Provider> Rent { get; set; } = [];

    [JsonPropertyName("ads")]
    public IReadOnlyList<Provider> Ads { get; set; } = [];

    [JsonPropertyName("free")]
    public IReadOnlyList<Provider> Free { get; set; } = [];
}
