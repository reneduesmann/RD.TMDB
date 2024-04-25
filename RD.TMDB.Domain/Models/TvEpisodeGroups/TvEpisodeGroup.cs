using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.TvEpisodeGroups;

public class TvEpisodeGroup
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("episodes")]
    public IReadOnlyList<TvEpisode> Episodes { get; set; } = [];
    
    [JsonPropertyName("locked")]
    public bool Locked { get; set; }
}
