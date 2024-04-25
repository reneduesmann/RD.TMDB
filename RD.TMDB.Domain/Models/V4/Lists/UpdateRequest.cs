namespace RD.TMDB.Domain.Models.V4.Lists;

public class UpdateRequest
{
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("public")]
    public required bool Public { get; set; }

    [JsonPropertyName("sort_by")]
    public required string SortBy { get; set; }
}
