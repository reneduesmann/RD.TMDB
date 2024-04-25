namespace RD.TMDB.Domain.Models.Authentications;

public class SessionWithLogin
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTimeOffset ExpiresAt { get; set; }

    [JsonPropertyName("request_token")]
    public string? RequestToken { get; set; }
}
