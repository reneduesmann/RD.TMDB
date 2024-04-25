namespace RD.TMDB.Domain.Models.Keywords;

public class KeywordContainer
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("keywords")]
    public IReadOnlyList<Keyword> Keywords { get; set; } = [];
}
