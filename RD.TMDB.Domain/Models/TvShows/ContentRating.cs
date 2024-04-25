using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.TvShows;

public class ContentRating
{
    [JsonPropertyName("descriptors")]
    public IReadOnlyList<object> Descriptors { get; set; } = [];
    
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("rating")]
    public string? Rating { get; set; }
}