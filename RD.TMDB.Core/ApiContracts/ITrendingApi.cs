using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface ITrendingApi
{
    /// <summary>
    /// Get the trending movies, TV shows and people.
    /// </summary>
    /// <param name="timeWindow"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/trending/all/{timeWindow}")]
    Task<ResultContainer<IKnownFor>> GetAllTrendingsAsync(
        string timeWindow,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending movies on TMDB.
    /// </summary>
    /// <param name="timewindow"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/trending/movie/{timewindow}")]
    Task<ResultContainer<Movie>> GetTrendingMoviesAsync(
        string timewindow,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending people on TMDB.
    /// </summary>
    /// <param name="timeWindow"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/trending/person/{timeWindow}")]
    Task<ResultContainer<Person>> GetTrendingPersonsAsync(
        string timeWindow,
        string? language = null,
        CancellationToken cancellationToken = default);

    [Get("/trending/tv/{timeWindow}")]
    Task<ResultContainer<TvShow>> GetTrendingTvShowsAsync(
        string timeWindow,
        string? language = null,
        CancellationToken cancellationToken = default);
}
