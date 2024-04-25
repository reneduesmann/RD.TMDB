namespace RD.TMDB.Domain.Models.Configurations;

public class Job
{
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    [JsonPropertyName("jobs")]
    public IReadOnlyList<string> Jobs { get; set; } = [];
}