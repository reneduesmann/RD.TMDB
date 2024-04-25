namespace RD.TMDB.Domain.Models.V4.Lists;

public class ItemsResponse : Response
{
    [JsonPropertyName("results")]
    public IReadOnlyList<ItemResponse> Results { get; set; } = [];
}
