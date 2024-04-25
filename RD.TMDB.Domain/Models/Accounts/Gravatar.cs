namespace RD.TMDB.Domain.Models.Accounts;

public class Gravatar
{
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
}
