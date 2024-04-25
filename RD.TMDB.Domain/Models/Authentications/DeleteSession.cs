namespace RD.TMDB.Domain.Models.Authentications;

public class DeleteSession
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
