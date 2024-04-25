namespace RD.TMDB.Domain.Models.Credits;

public class Credit<TCast, TCrew>
    where TCast : class
    where TCrew : class
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cast")]
    public IReadOnlyList<TCast> Casts { get; set; } = [];

    [JsonPropertyName("crew")]
    public IReadOnlyList<TCrew> Crews { get; set; } = [];
}