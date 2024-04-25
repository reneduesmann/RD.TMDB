using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Collections;

public class CollectionDetail
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }
    
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
    
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("parts")]
    public IReadOnlyList<Movie> Parts { get; set; } = [];
}