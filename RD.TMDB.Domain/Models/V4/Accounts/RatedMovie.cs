using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.V4.Accounts;

public class RatedMovie : Movie
{
    [JsonPropertyName("account_rating")]
    public AccountRating? AccountRating { get; set; }
}
