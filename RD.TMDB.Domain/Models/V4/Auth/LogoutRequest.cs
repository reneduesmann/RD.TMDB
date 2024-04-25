namespace RD.TMDB.Domain.Models.V4.Auth;

public class LogoutRequest
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; }

    public LogoutRequest(string accessToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accessToken);

        this.AccessToken = accessToken;
    }
}
