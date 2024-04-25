namespace RD.TMDB.Domain.Models.Authentications;

public class GuestSession
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
    
    [JsonPropertyName("guest_session_id")]
    public string? GuestSessionId { get; set; }
    
    [JsonPropertyName("expires_at")]
    public DateTimeOffset ExpiresAt { get; set; }
}