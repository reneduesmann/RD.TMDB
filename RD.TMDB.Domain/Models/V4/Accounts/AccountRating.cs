namespace RD.TMDB.Domain.Models.V4.Accounts;

public class AccountRating
{
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("value")]
    public double Value { get; set; }
}
