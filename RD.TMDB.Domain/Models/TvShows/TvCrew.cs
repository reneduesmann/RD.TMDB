using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.TvShows;

public class TvCrew
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("known_for_department")]
    public Department KnownForDepartment { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }
    
    [JsonPropertyName("popularity")]
    public double Popularity { get; set; }
    
    [JsonPropertyName("profile_path")]
    public string? ProfilePath { get; set; }

    [JsonPropertyName("jobs")]
    public IReadOnlyList<Job> Jobs { get; set; } = [];
    
    [JsonPropertyName("department")]
    public Department Department { get; set; }
    
    [JsonPropertyName("total_episode_count")]
    public int TotalEpisodeCount { get; set; }
}
