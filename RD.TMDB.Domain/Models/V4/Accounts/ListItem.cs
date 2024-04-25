using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.V4.Accounts;

public class ListItem
{
    [JsonPropertyName("account_object_id")]
    public string? AccountObjectId { get; set; }
    
    [JsonPropertyName("adult")]
    public int Adult { get; set; }
    
    [JsonPropertyName("average_rating")]
    public double AverageRating { get; set; }
    
    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("featured")]
    public int Featured { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("number_of_items")]
    public int NumberOfItems { get; set; }
    
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }
    
    [JsonPropertyName("public")]
    public int Public { get; set; }
    
    [JsonPropertyName("revenue")]
    public int Revenue { get; set; }
    
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
    
    [JsonPropertyName("sort_by")]
    public int SortBy { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
}