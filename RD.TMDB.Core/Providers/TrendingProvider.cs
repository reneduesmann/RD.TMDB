using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Shared;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ITrendingProvider
{
    private ITrendingApi? _trendingApi;

    private ITrendingApi TrendingApi => this._trendingApi ??= this.CreateRefitInterface<ITrendingApi>();

    public async Task<ResultContainer<IKnownFor>> GetAllTrendingAsync(TimeWindow timeWindow, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? timeWindowToUse = this._enumCache.GetStringValue(timeWindow);

        if (string.IsNullOrWhiteSpace(timeWindowToUse))
        {
            throw new ArgumentException(string.Format(InvalidPropertyValue, nameof(TimeWindow)), nameof(timeWindow));
        }

        string? languageToUse = this.GetLanguage(language);

        return await this.TrendingApi.GetAllTrendingsAsync(timeWindowToUse, languageToUse, cancellationToken);
    }

    public async Task<ResultContainer<Movie>> GetTrendingMoviesAsync(TimeWindow timeWindow, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? timeWindowToUse = this._enumCache.GetStringValue(timeWindow);

        if (string.IsNullOrWhiteSpace(timeWindowToUse))
        {
            throw new ArgumentException(string.Format(InvalidPropertyValue, nameof(TimeWindow)), nameof(timeWindow));
        }

        string? languageToUse = this.GetLanguage(language);

        return await this.TrendingApi.GetTrendingMoviesAsync(timeWindowToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Person>> GetTrendingPersonsAsync(TimeWindow timeWindow, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? timeWindowToUse = this._enumCache.GetStringValue(timeWindow);

        if (string.IsNullOrWhiteSpace(timeWindowToUse))
        {
            throw new ArgumentException(string.Format(InvalidPropertyValue, nameof(TimeWindow)), nameof(timeWindow));
        }

        string? languageToUse = this.GetLanguage(language);

        return await this.TrendingApi.GetTrendingPersonsAsync(timeWindowToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetTrendingTvShowsAsync(TimeWindow timeWindow, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? timeWindowToUse = this._enumCache.GetStringValue(timeWindow);

        if (string.IsNullOrWhiteSpace(timeWindowToUse))
        {
            throw new ArgumentException(string.Format(InvalidPropertyValue, nameof(TimeWindow)), nameof(timeWindow));
        }

        string? languageToUse = this.GetLanguage(language);

        return await this.TrendingApi.GetTrendingTvShowsAsync(timeWindowToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }
}
