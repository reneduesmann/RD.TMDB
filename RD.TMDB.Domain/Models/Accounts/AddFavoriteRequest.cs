namespace RD.TMDB.Domain.Models.Accounts;

public class AddFavoriteRequest
{
    [JsonPropertyName("media_type")]
    public required string MediaType { get; set; }

    [JsonPropertyName("media_id")]
    public required int MediaId { get; set; }

    [JsonPropertyName("favorite")]
    public required bool Favorite { get; set; }
}
