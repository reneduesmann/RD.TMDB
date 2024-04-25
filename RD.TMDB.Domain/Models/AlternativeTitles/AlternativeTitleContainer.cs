namespace RD.TMDB.Domain.Models.AlternativeTitles;

public class AlternativeTitleContainer
{
    [JsonPropertyName("titles")]
    public IReadOnlyList<AlternativeTitle> Titles { get; set; } = [];
}