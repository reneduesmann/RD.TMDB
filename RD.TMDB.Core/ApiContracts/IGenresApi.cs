using RD.TMDB.Domain.Models.Genres;

namespace RD.TMDB.Core.ApiContracts;

public interface IGenresApi
{
    /// <summary>
    /// Get the list of official genres for movies.
    /// </summary>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/genre/movie/list")]
    Task<GenreContainer> GetMovieGenresAsync(
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of official genres for TV shows.
    /// </summary>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/genre/tv/list")]
    Task<GenreContainer> GetTvShowGenresAsync(
        string? language = null,
        CancellationToken cancellationToken = default);
}
