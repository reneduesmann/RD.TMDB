using RD.TMDB.Domain.Models.Images;

namespace RD.TMDB.Domain.Models.Persons;

public class PersonImage
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("profiles")]
    public IReadOnlyList<ImageBase> Profiles { get; set; } = [];
}
