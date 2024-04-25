using RD.TMDB.Domain.Models.Credits;

namespace RD.TMDB.Domain.Models.TvEpisodes;

public class TvEpisodeDetail : TvEpisodeDetailAppendToResponseData
{
    [JsonPropertyName("air_date")]
    public DateOnly AirDate { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    [JsonPropertyName("episode_type")]
    public string? EpisodeType { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("production_code")]
    public string? ProductionCode { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("show_id")]
    public int ShowId { get; set; }

    [JsonPropertyName("still_path")]
    public string? StillPath { get; set; }

    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("crew")]
    public IReadOnlyList<Crew> Crews { get; set; } = [];

    [JsonPropertyName("guest_stars")]
    public IReadOnlyList<GuestStar> GuestStars { get; set; } = [];
}