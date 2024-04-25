using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.V4.Accounts;

namespace RD.TMDB.Core.Contracts.V4;

public interface IAccountProvider
{
    /// <summary>
    /// Get all of the lists you've created.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<ListItem>> GetAccountListsAsync(string accountId, int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of favourite movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<Movie>> GetFavoriteMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of favourite TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<TvShow>> GetFavoriteTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's rated movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's rated TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of recommended movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<Movie>> GetRecommendedMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's list of recommended TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<TvShow>> GetRecommendedTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's movie watchlist.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<Movie>> GetWatchlistMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a user's TV watchlist.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ResultContainer<TvShow>> GetWatchlistTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default);
}
