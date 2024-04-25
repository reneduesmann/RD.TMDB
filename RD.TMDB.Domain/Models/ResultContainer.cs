namespace RD.TMDB.Domain.Models;

public class ResultContainer<TResult> where TResult : class
{
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("results")]
    public IReadOnlyList<TResult> Results { get; set; } = [];

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
