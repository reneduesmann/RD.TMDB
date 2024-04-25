using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class ReleaseDate
{
    [JsonPropertyName("certification")]
    public string? Certification { get; set; }

    [JsonPropertyName("descriptors")]
    public IReadOnlyList<object> Descriptors { get; set; } = [];

    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }

    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("release_date")]
    public DateOnly Date { get; set; }

    [JsonPropertyName("type")]
    public ReleaseType Type { get; set; }
}
