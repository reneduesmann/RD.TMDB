namespace RD.TMDB.Domain.Models.Reviews;

public class Author
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    
    [JsonPropertyName("avatar_path")]
    public string? AvatarPath { get; set; }
    
    [JsonPropertyName("rating")]
    public double? Rating { get; set; }
}
