namespace RD.TMDB.Domain.Models.V4.Lists;

public class CreateRequest
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("iso_3166_1")]
    public string? Country { get; set; }

    [JsonPropertyName("iso_639_1")]
    public string Language { get; }

    [JsonPropertyName("public")]
    public bool Public { get; }

    public CreateRequest(string name, string language, bool @public)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(language);

        this.Name = name;
        this.Language = language;
        this.Public = @public;
    }
}