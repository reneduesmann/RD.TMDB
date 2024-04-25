using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.V4.Accounts;

public class RatedTvShow : TvShow
{
    [JsonPropertyName("account_rating")]
    public AccountRating? AccountRating { get; set; }
}
