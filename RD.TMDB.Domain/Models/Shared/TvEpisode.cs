using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class TvEpisode
{
    [JsonPropertyName("air_date")]
    public DateOnly AirDate { get; set; }
    
    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }
    
    [JsonPropertyName("production_code")]
    public string? ProductionCode { get; set; }
    
    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }
    
    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }
    
    [JsonPropertyName("show_id")]
    public int ShowId { get; set; }
    
    [JsonPropertyName("still_path")]
    public string? StillPath { get; set; }
    
    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }
    
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; } = MediaType.TvEpisode;

    [JsonPropertyName("episode_type")]
    public string? EpisodeType { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }
}