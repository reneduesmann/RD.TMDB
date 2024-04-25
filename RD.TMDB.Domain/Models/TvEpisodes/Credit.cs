using RD.TMDB.Domain.Models.Credits;

namespace RD.TMDB.Domain.Models.TvEpisodes;

public class Credit
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cast")]
    public IReadOnlyList<Cast> Casts { get; set; } = [];

    [JsonPropertyName("crew")]
    public IReadOnlyList<Crew> Crews { get; set; } = [];

    [JsonPropertyName("guest_stars")]
    public IReadOnlyList<GuestStar> GuestStars { get; set; } = [];
}
