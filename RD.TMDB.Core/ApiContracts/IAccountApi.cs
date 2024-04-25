using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface IAccountApi
{
    [Get("/account/{accountId}")]
    Task<Account> GetDetailsAsync(int accountId, [AliasAs("session_id")] string sessionId, 
        CancellationToken cancellationToken = default);

    [Post("/account/{accountId}/favorite")]
    Task<Response> AddFavoriteAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        [Body(BodySerializationMethod.Serialized)] AddFavoriteRequest request, 
        CancellationToken cancellationToken = default);

    [Post("/account/{accountId}/watchlist")]
    Task<Response> AddToWatchlistAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        [Body(BodySerializationMethod.Serialized)] AddToWatchlistRequest request, 
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/favorite/movies")]
    Task<ResultContainer<Movie>> GetFavoriteMoviesAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null, 
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/favorite/tv")]
    Task<ResultContainer<TvShow>> GetFavoriteTvShowsAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null, 
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/lists")]
    Task<ResultContainer<ListItem>> GetListsAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        int? page = null, 
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/rated/movies")]
    Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null, 
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/rated/tv")]
    Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null, 
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/rated/tv/episodes")]
    Task<ResultContainer<RatedTvEpisode>> GetRatedTvEpisodesAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null,
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/watchlist/movies")]
    Task<ResultContainer<Movie>> GetMovieWatchlistAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null,
        CancellationToken cancellationToken = default);

    [Get("/account/{accountId}/watchlist/tv")]
    Task<ResultContainer<TvShow>> GetTvShowWatchlistAsync(
        int accountId,
        [AliasAs("session_id")] string sessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null,
        CancellationToken cancellationToken = default);
}
