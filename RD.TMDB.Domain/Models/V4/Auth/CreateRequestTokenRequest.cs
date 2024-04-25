namespace RD.TMDB.Domain.Models.V4.Auth;

public class CreateRequestTokenRequest
{
    [JsonPropertyName("redirect_to")]
    public string RedirectTo { get; }

    public CreateRequestTokenRequest(string redirectTo)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(redirectTo);

        this.RedirectTo = redirectTo;
    }
}
