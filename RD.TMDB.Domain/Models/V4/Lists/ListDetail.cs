using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.V4.Lists;

public class ListDetail : ResultContainer<IKnownFor>
{
    [JsonPropertyName("average_rating")]
    public double AverageRating { get; set; }
    
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("comments")]
    public Dictionary<string, object> Comments { get; set; } = [];
    
    [JsonPropertyName("created_by")]
    public CreatedBy? CreatedBy { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("item_count")]
    public int ItemCount { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("object_ids")]
    public object? ObjectIds { get; set; }
    
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
    
    [JsonPropertyName("public")]
    public bool Public { get; set; }
    
    [JsonPropertyName("revenue")]
    public int Revenue { get; set; }
    
    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }
    
    [JsonPropertyName("sort_by")]
    public string? SortBy { get; set; }
}