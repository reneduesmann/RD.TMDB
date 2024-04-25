namespace RD.TMDB.Domain.Models.V4.Auth;

public class CreateAccessTokenRequest
{
    [JsonPropertyName("request_token")]
    public string RequestToken { get; }

    public CreateAccessTokenRequest(string requestToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(requestToken);

        this.RequestToken = requestToken;
    }
}
