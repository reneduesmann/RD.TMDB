namespace RD.TMDB.Domain.Models.Accounts;

public class Avatar
{
    [JsonPropertyName("gravatar")]
    public Gravatar? Gravatar { get; set; }

    [JsonPropertyName("tmdb")]
    public Tmdb? Tmdb { get; set; }
}
