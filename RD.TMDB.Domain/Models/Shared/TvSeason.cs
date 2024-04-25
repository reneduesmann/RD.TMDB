using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public class TvSeason
{
    /// <summary>
    /// Air date of the tv season.
    /// </summary>
    [JsonPropertyName("air_date")]
    public DateOnly AirDate { get; set; }

    /// <summary>
    /// Count of episodes from the tv season.
    /// </summary>
    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }

    /// <summary>
    /// Id of the tv season.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Name of the tv season.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Overview/Description of the tv season.
    /// </summary>
    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("media_type")]
    public MediaType MediaType { get; set; } = MediaType.TvSeason;

    [JsonPropertyName("vote_average")]
    public double VoteAverage { get; set; }

    /// <summary>
    /// Path to the poster.
    /// </summary>
    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    /// <summary>
    /// Number of the season.
    /// </summary>
    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    /// <summary>
    /// Id of the tv show.
    /// </summary>
    [JsonPropertyName("show_id")]
    public int TvShowId { get; set; }
}