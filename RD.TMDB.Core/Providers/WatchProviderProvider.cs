using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IWatchProviderProvider
{
    private IWatchProvidersApi? _watchProvidersApi;

    private IWatchProvidersApi WatchProvidersApi => this._watchProvidersApi ??= this.CreateRefitInterface<IWatchProvidersApi>();

    public async Task<Result<Region>> GetAvailableRegionsAsync(Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.WatchProvidersApi.GetAvailableRegionsAsync(languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<Provider>> GetMovieProvidersAsync(Iso639_1? language = null, Iso3166_1? watchRegion = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);
        string? countryToUse = this.GetCountry(watchRegion);

        return await this.WatchProvidersApi.GetMovieProvidersAsync(languageToUse, countryToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<Provider>> GetTvShowProvidersAsync(Iso639_1? language = null, Iso3166_1? watchRegion = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);
        string? countryToUse = this.GetCountry(watchRegion);

        return await this.WatchProvidersApi.GetTvShowProvidersAsync(languageToUse, countryToUse, cancellationToken)
            .ConfigureAwait(false);
    }
}
