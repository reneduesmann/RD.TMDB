namespace RD.TMDB.Domain.Models.Reviews;

public class Review
{
    [JsonPropertyName("author")]
    public string? Author { get; set; }
    
    [JsonPropertyName("author_details")]
    public Author? AuthorDetails { get; set; }
    
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
    
    [JsonPropertyName("url")]
    public Uri? Url { get; set; }
}