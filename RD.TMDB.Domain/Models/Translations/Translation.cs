using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Translations;

public class Translation<TData> where TData : TranslationData
{
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }
    
    [JsonPropertyName("data")]
    public TData? Data { get; set; }
}
