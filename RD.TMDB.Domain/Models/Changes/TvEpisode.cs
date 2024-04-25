namespace RD.TMDB.Domain.Models.Changes;

public class TvEpisode
{
    [JsonPropertyName("episode_id")]
    public int EpisodeId { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }
}
