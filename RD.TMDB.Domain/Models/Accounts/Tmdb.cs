namespace RD.TMDB.Domain.Models.Accounts;

public class Tmdb
{
    [JsonPropertyName("avatar_path")]
    public string? AvatarPath { get; set; }
}
