namespace RD.TMDB.Domain.Models.Authentications;

public class CreateSessionWithLoginRequest
{
    [JsonPropertyName("username")]
    public string Username { get; }

    [JsonPropertyName("password")]
    public string Password { get; }

    [JsonPropertyName("request_token")]
    public string RequestToken { get; }

    public CreateSessionWithLoginRequest(string username, string password, string requestToken)
    {
        if(string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentNullException(nameof(username));
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentNullException(nameof(password));
        }

        if (string.IsNullOrWhiteSpace(requestToken))
        {
            throw new ArgumentNullException(nameof(requestToken));
        }

        this.Username = username;
        this.Password = password;
        this.RequestToken = requestToken;
    }
}
