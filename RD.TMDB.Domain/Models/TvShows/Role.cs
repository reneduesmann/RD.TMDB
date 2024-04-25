namespace RD.TMDB.Domain.Models.TvShows;

public class Role
{
    [JsonPropertyName("credit_id")]
    public string? CreditId { get; set; }
    
    [JsonPropertyName("character")]
    public string? Character { get; set; }
    
    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }
}
