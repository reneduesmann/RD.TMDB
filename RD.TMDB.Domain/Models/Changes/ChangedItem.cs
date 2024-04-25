namespace RD.TMDB.Domain.Models.Changes;

public class ChangedItem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }
}
