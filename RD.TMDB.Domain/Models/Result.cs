namespace RD.TMDB.Domain.Models;

public class Result<TResult> where TResult : class
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public IReadOnlyList<TResult> Results { get; set; } = [];
}
