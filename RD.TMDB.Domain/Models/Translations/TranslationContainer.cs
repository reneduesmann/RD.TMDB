namespace RD.TMDB.Domain.Models.Translations;

public class TranslationContainer<TData> where TData : TranslationData
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("translations")]
    public IReadOnlyList<Translation<TData>> Translations { get; set; } = [];
}