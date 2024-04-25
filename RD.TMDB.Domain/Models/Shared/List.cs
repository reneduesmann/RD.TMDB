using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class List
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("favorite_count")]
    public int FavoriteCount { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("item_count")]
    public int ItemCount { get; set; }

    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }

    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }

    [JsonPropertyName("list_type")]
    public ListType ListType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
}