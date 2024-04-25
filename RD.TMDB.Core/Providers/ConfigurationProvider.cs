using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Configurations;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IConfigurationProvider
{
    private IConfigurationsApi? _configurationsApi;

    private IConfigurationsApi ConfigurationsApi => this._configurationsApi ??= this.CreateRefitInterface<IConfigurationsApi>();

    public async Task<ApiConfiguration> GetApiConfigurationAsync(CancellationToken cancellationToken = default)
    {
        return this._apiConfiguration ??= await this.ConfigurationsApi
            .GetApiConfigurationAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<IReadOnlyList<Country>> GetCountriesAsync(string? language = null, CancellationToken cancellationToken = default)
    {
        return await this.ConfigurationsApi.GetCountriesAsync(language, cancellationToken).ConfigureAwait(false);
    }

    public async Task<IReadOnlyList<Job>> GetJobsAsync(CancellationToken cancellationToken = default)
    {
        return await this.ConfigurationsApi.GetJobsAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<IReadOnlyList<Language>> GetLanguagesAsync(CancellationToken cancellationToken = default)
    {
        return await this.ConfigurationsApi.GetLanguagesAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<IReadOnlyList<CountryAndLanguage>> GetPrimaryTranslationsAsync(CancellationToken cancellationToken = default)
    {
        return await this.ConfigurationsApi.GetPrimaryTranslationsAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<IReadOnlyList<Timezone>> GetTimezonesAsync(CancellationToken cancellationToken = default)
    {
        return await this.ConfigurationsApi.GetTimezonesAsync(cancellationToken).ConfigureAwait(false);
    }
}
