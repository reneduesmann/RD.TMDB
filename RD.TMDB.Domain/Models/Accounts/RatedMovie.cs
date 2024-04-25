using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Accounts;

public class RatedMovie : Movie
{
    [JsonPropertyName("rating")]
    public double Rating { get; set; }
}
