using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Configurations;

public class Timezone
{
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }

    [JsonPropertyName("zones")]
    public IReadOnlyList<string> Zones { get; set; } = [];
}