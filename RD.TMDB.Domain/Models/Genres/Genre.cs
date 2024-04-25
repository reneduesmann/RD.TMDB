namespace RD.TMDB.Domain.Models.Genres;

public class Genre
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
