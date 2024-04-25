using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Changes;

public class ChangeItem<TDataType> : IChangeItem
{
    [JsonPropertyName("key")]
    public ChangeKey Key { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("action")]
    public ItemAction Action { get; set; }
    
    [JsonPropertyName("time")]
    public DateTimeOffset Time { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }

    [JsonPropertyName("value")]
    public TDataType? Value { get; set; }

    [JsonPropertyName("original_value")]
    public TDataType? OriginalValue { get; set; }
}
