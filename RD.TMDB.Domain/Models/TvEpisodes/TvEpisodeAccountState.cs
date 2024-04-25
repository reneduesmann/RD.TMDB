namespace RD.TMDB.Domain.Models.TvEpisodes;

public class TvEpisodeAccountState
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("rated")]
    public bool Rated { get; set; }

    [JsonIgnore]
    public double RatedValue { get; set; }
}
