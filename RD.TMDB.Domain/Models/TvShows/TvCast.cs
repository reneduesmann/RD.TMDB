using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.TvShows;

public class TvCast
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

    [JsonPropertyName("roles")]
    public IReadOnlyList<Role> Roles { get; set; } = [];
    
    [JsonPropertyName("total_episode_count")]
    public int TotalEpisodeCount { get; set; }
    
    [JsonPropertyName("order")]
    public int Order { get; set; }
}