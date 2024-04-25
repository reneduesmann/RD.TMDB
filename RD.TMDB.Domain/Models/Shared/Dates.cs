namespace RD.TMDB.Domain.Models.Shared;

public class Dates
{
    [JsonPropertyName("maximum")]
    public DateOnly Maximum { get; set; }
    
    [JsonPropertyName("minimum")]
    public DateOnly Minimum { get; set; }
}
