namespace RD.TMDB.Domain.Models.Lists;

public class CreateListRequest
{
    [JsonPropertyName("name")]
    public string Name { get; }

    [JsonPropertyName("description")]
    public string? Description { get; set; } = null;

    [JsonPropertyName("language")]
    public string? Language { get; set; } = null;

    public CreateListRequest(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        this.Name = name;
    }
}
