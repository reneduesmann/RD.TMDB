namespace RD.TMDB.Domain.Models.Networks;

public class NetworkImageContainer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public IReadOnlyList<NetworkImage> Logos { get; set; } = [];
}
