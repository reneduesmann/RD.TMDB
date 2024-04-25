using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class ReleaseDateContainer
{
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }

    [JsonPropertyName("release_dates")]
    public IReadOnlyList<ReleaseDate> ReleaseDates { get; set; } = [];
}
