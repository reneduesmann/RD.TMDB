using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Accounts;

public class RatedTvEpisode : TvEpisode
{
    [JsonPropertyName("rating")]
    public double Rating { get; set; }
}
