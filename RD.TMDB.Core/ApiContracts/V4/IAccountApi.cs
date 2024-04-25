using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.V4.Accounts;

namespace RD.TMDB.Core.ApiContracts.V4;

public interface IAccountApi
{
    /// <summary>
    /// Get all of the lists you've created.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/lists")]
    Task<ResultContainer<ListItem>> GetListsAsync(
        string accountId,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of favourite movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/movie/favorites")]
    Task<ResultContainer<Movie>> GetFavoriteMoviesAsync(
        string accountId,
        int? page = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of favourite TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/tv/favorites")]
    Task<ResultContainer<TvShow>> GetFavoriteTvShowsAsync(
        string accountId,
        int? page = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's rated movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/movie/rated")]
    Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(
        string accountId,
        int? page = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's rated TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/tv/rated")]
    Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(
        string accountId,
        int? page = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of recommended movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/movie/recommendations")]
    Task<ResultContainer<Movie>> GetRecommendedMoviesAsync(
        string accountId,
        int? page = null,
        string? language = null, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of recommended TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/tv/recommendations")]
    Task<ResultContainer<TvShow>> GetRecommendedTvShowsAsync(
        string accountId,
        int? page = null,
        string? language = null, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's movie watchlist.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/movie/watchlist")]
    Task<ResultContainer<Movie>> GetWatchlistMoviesAsync(
        string accountId,
        int? page = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's TV watchlist.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/account/{accountId}/tv/watchlist")]
    Task<ResultContainer<TvShow>> GetWatchlistTvShowsAsync(
        string accountId,
        int? page = null,
        string? language = null,
        CancellationToken cancellationToken = default);
}
