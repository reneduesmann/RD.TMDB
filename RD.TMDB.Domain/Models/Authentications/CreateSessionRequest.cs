namespace RD.TMDB.Domain.Models.Authentications;

public class CreateSessionRequest
{
    [JsonPropertyName("request_token")]
    public string RequestToken { get; }

    public CreateSessionRequest(string requestToken)
    {
        if(string.IsNullOrWhiteSpace(requestToken))
        {
            throw new ArgumentNullException(nameof(requestToken));
        }

        this.RequestToken = requestToken;
    }
}
