namespace RD.TMDB.Domain.Models.TvShows;

public class Job
{
    [JsonPropertyName("credit_id")]
    public string? CreditId { get; set; }
    
    [JsonPropertyName("job")]
    public string? Name { get; set; }
    
    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }
}
