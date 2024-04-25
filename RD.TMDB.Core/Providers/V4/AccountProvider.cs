using RD.TMDB.Core.ApiContracts.V4;
using RD.TMDB.Core.Contracts.V4;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.V4.Accounts;

namespace RD.TMDB.Core.Providers.V4;

public sealed partial class TmdbV4Client : IAccountProvider
{
    private IAccountApi? _accountApi;

    private IAccountApi AccountApi => this._accountApi ??= this.CreateRefitInterface<IAccountApi>();

    /// <summary>
    /// Get all of the lists you've created.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<ListItem>> GetAccountListsAsync(string accountId, int? page = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        return await this.AccountApi.GetListsAsync(accountId, page, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's list of favourite movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<Movie>> GetFavoriteMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetFavoriteMoviesAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's list of favourite TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<TvShow>> GetFavoriteTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetFavoriteTvShowsAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's rated movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetRatedMoviesAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's rated TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetRatedTvShowsAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's list of recommended movies.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<Movie>> GetRecommendedMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetRecommendedMoviesAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's list of recommended TV shows.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<TvShow>> GetRecommendedTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetRecommendedTvShowsAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's movie watchlist.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<Movie>> GetWatchlistMoviesAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetWatchlistMoviesAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Get a user's TV watchlist.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="page"></param>
    /// <param name="language"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ResultContainer<TvShow>> GetWatchlistTvShowsAsync(string accountId, int? page = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accountId);

        string? languageToUse = this.GetLanguage(language);

        return await this.AccountApi.GetWatchlistTvShowsAsync(accountId, page, languageToUse,
            cancellationToken).ConfigureAwait(false);
    }
}
