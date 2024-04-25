using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.TvShows;

public class CreatedBy
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("credit_id")]
    public string? CreditId { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }
    
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }
    
    [JsonPropertyName("profile_path")]
    public string? ProfilePath { get; set; }
}
