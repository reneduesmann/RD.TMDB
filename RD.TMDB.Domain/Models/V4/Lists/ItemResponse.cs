namespace RD.TMDB.Domain.Models.V4.Lists;

public class ItemResponse
{
    [JsonPropertyName("media_type")]
    public string? MediaType { get; set; }

    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
