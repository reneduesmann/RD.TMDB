using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface IAccountProvider
{
    Task<Response> AddFavoriteAsync(int accountId, string sessionId, AddFavoriteRequest request, CancellationToken cancellationToken = default);
    
    Task<Response> AddFavoriteAsync(int accountId, string sessionId, MediaType mediaType, int mediaId, bool favorite, CancellationToken cancellationToken = default);
    
    Task<Response> AddToWatchlistAsync(int accountId, string sessionId, AddToWatchlistRequest request, CancellationToken cancellationToken = default);
    
    Task<Response> AddToWatchlistAsync(int accountId, string sessionId, MediaType mediaType, int mediaId, bool watchlist, CancellationToken cancellationToken = default);
    
    Task<Account> GetAccountDetailsAsync(int accountId, string sessionId, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetFavoriteMoviesAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetFavoriteTvShowsAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<ListItem>> GetListsAsync(int accountId, string sessionId, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetMovieWatchlistAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<RatedTvEpisode>> GetRatedTvEpisodesAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetTvShowWatchlistAsync(int accountId, string sessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
}