namespace RD.TMDB.Domain.Models.TvSeasons;

public class TvSeasonAccountState
{
    [JsonPropertyName("rated")]
    public bool Rated { get; set; }

    [JsonIgnore]
    public double RatedValue { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}