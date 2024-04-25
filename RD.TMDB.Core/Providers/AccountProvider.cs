using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IAccountProvider
{
    private IAccountApi? _accountApi;

    private IAccountApi AccountApi => this._accountApi ??= this.CreateRefitInterface<IAccountApi>();

    public async Task<Account> GetAccountDetailsAsync(int accountId, string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        return await this.AccountApi.GetDetailsAsync(accountId, sessionId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Response> AddFavoriteAsync(int accountId, string sessionId, AddFavoriteRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);
        ArgumentNullException.ThrowIfNull(request);

        return await this.AccountApi.AddFavoriteAsync(accountId, sessionId, request, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Response> AddFavoriteAsync(int accountId, string sessionId, MediaType mediaType, int mediaId, bool favorite,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        if (mediaType == MediaType.Undefined)
        {
            throw new ArgumentOutOfRangeException(nameof(mediaType));
        }

        AddFavoriteRequest addFavoriteRequest = new()
        {
            Favorite = favorite,
            MediaId = mediaId,
            MediaType = this._enumCache.GetStringValue(mediaType)!
        };

        return await this.AccountApi.AddFavoriteAsync(accountId, sessionId, addFavoriteRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> AddToWatchlistAsync(int accountId, string sessionId, AddToWatchlistRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);
        ArgumentNullException.ThrowIfNull(request);

        return await this.AccountApi.AddToWatchlistAsync(accountId, sessionId, request, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Response> AddToWatchlistAsync(int accountId, string sessionId, MediaType mediaType, int mediaId, bool watchlist,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        if (mediaType == MediaType.Undefined)
        {
            throw new ArgumentOutOfRangeException(nameof(mediaType));
        }

        AddToWatchlistRequest addToWatchlistRequest = new()
        {
            MediaId = mediaId,
            MediaType = this._enumCache.GetStringValue(mediaType)!,
            Watchlist = watchlist
        };

        return await this.AccountApi.AddToWatchlistAsync(accountId, sessionId, addToWatchlistRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetFavoriteMoviesAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetFavoriteMoviesAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetFavoriteTvShowsAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetFavoriteTvShowsAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<ListItem>> GetListsAsync(int accountId, string sessionId, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        return await this.AccountApi.GetListsAsync(accountId, sessionId, page, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetRatedMoviesAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetRatedTvShowsAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<RatedTvEpisode>> GetRatedTvEpisodesAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetRatedTvEpisodesAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetMovieWatchlistAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetMovieWatchlistAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetTvShowWatchlistAsync(int accountId, string sessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = sortBy.HasValue ? this._enumCache.GetStringValue(sortBy.Value) : null;

        return await this.AccountApi.GetTvShowWatchlistAsync(accountId, sessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }
}
