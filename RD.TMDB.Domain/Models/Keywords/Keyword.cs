namespace RD.TMDB.Domain.Models.Keywords;

public class Keyword
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
