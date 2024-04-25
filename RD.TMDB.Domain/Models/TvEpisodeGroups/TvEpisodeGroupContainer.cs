using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Networks;

namespace RD.TMDB.Domain.Models.TvEpisodeGroups;

public class TvEpisodeGroupContainer
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }
    
    [JsonPropertyName("group_count")]
    public int GroupCount { get; set; }

    [JsonPropertyName("groups")]
    public IReadOnlyList<TvEpisodeGroup> Groups { get; set; } = [];
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("network")]
    public Network? Network { get; set; }
    
    [JsonPropertyName("type")]
    public GroupType Type { get; set; }
}