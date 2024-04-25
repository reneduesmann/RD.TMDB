namespace RD.TMDB.Domain.Models.Images;

public class Image
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("backdrops")]
    public IReadOnlyList<ImageBase> Backdrops { get; set; } = [];

    [JsonPropertyName("posters")]
    public IReadOnlyList<ImageBase> Posters { get; set; } = [];

    [JsonPropertyName("logos")]
    public IReadOnlyList<ImageBase> Logos { get; set; } = [];

    [JsonPropertyName("stills")]
    public IReadOnlyList<ImageBase> Stills { get; set; } = [];
}