namespace RD.TMDB.Domain.Models.Lists;

public class ItemStatus
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("item_present")]
    public bool ItemPresent { get; set; }
}
