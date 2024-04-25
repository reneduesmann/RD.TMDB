using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Accounts;

public class RatedTvShow : TvShow
{
    [JsonPropertyName("rating")]
    public double Rating { get; set; }
}