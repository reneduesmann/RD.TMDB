namespace RD.TMDB.Domain.Models.Translations;

public class TranslationData
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }
    
    [JsonPropertyName("homepage")]
    public Uri? Homepage { get; set; }
}
