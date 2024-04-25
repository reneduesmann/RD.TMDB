namespace RD.TMDB.Domain.Models.Changes;

public class ChangeContainer
{
    [JsonPropertyName("changes")]
    public IReadOnlyList<Change> Changes { get; set; } = [];
}