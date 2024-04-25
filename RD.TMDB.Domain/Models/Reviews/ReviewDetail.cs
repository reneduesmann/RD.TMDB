using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Reviews;

public class ReviewDetail
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("author")]
    public string? Author { get; set; }
    
    [JsonPropertyName("author_details")]
    public Author? AuthorDetails { get; set; }
    
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }
    
    [JsonPropertyName("media_title")]
    public string? MediaTitle { get; set; }
    
    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
    
    [JsonPropertyName("url")]
    public Uri? Url { get; set; }
}