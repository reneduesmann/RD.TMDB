namespace RD.TMDB.Domain.Models.Authentications;

public class Session
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }
}
