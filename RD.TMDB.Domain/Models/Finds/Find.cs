using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Domain.Models.Finds;

public class Find
{
    [JsonPropertyName("movie_results")]
    public IReadOnlyList<Movie> Movies { get; set; } = [];

    [JsonPropertyName("person_results")]
    public IReadOnlyList<Person> Persons { get; set; } = [];

    [JsonPropertyName("tv_results")]
    public IReadOnlyList<TvShow> TvShows { get; set; } = [];

    [JsonPropertyName("tv_episode_results")]
    public IReadOnlyList<TvEpisode> TvEpisodes { get; set; } = [];

    [JsonPropertyName("tv_season_results")]
    public IReadOnlyList<TvSeason> TvSeasons { get; set; } = [];
}