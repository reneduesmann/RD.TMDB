namespace RD.TMDB.Domain.Models.Changes;

public class Tagline
{
    [JsonPropertyName("primary")]
    public bool Primary { get; set; }

    [JsonPropertyName("tagline")]
    public string? Value { get; set; }
}
