namespace RD.TMDB.Domain.Models.V4.Lists;

public class CreatedBy
{
    [JsonPropertyName("avatar_path")]
    public string? AvatarPath { get; set; }
    
    [JsonPropertyName("gravatar_hash")]
    public string? GravatarHash { get; set; }
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
