namespace RD.TMDB.Domain.Models.Authentications;

public class DeleteSessionRequest
{
    [JsonPropertyName("session_id")]
    public string SessionId { get; }

    public DeleteSessionRequest(string sessionId)
    {
        if(string.IsNullOrWhiteSpace(sessionId))
        {
            throw new ArgumentNullException(nameof(sessionId));
        }

        this.SessionId = sessionId;
    }
}
