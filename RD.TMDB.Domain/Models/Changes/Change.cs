using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Changes;

public class Change
{
    [JsonPropertyName("key")]
    public ChangeKey Key { get; set; }

    [JsonPropertyName("items")]
    public IReadOnlyList<IChangeItem> Items { get; set; } = [];
}
