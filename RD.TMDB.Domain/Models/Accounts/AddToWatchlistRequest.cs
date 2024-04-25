namespace RD.TMDB.Domain.Models.Accounts;

public class AddToWatchlistRequest
{
    [JsonPropertyName("media_type")]
    public required string MediaType { get; set; }

    [JsonPropertyName("media_id")]
    public required int MediaId { get; set; }

    [JsonPropertyName("watchlist")]
    public required bool Watchlist { get; set; }
}
