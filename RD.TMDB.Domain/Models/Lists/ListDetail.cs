using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Lists;

public class ListDetail
{
    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("favorite_count")]
    public int FavoriteCount { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("items")]
    public IReadOnlyList<IKnownFor> Items { get; set; } = [];
    
    [JsonPropertyName("item_count")]
    public int ItemCount { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
}