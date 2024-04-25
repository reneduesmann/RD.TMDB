using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Configurations;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface IConfigurationsApi
{
    /// <summary>
    /// Query the API configuration details.
    /// </summary>
    /// <returns>The data returned here in the configuration endpoint is designed to provide some of the required information 
    /// you'll need as you integrate our API.
    /// For example, you can get a list of valid image sizes and the valid image address.</returns>
    [Get("/configuration")]
    Task<ApiConfiguration> GetApiConfigurationAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of countries (ISO 3166-1 tags) used throughout TMDB.
    /// </summary>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/configuration/countries")]
    Task<IReadOnlyList<Country>> GetCountriesAsync(
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of the jobs and departments we use on TMDB.
    /// </summary>
    /// <returns></returns>
    [Get("/configuration/jobs")]
    Task<IReadOnlyList<Job>> GetJobsAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of languages (ISO 639-1 tags) used throughout TMDB.
    /// </summary>
    /// <returns></returns>
    [Get("/configuration/languages")]
    Task<IReadOnlyList<Language>> GetLanguagesAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of the officially supported translations on TMDB.
    /// </summary>
    /// <returns></returns>
    [Get("/configuration/primary_translations")]
    Task<IReadOnlyList<CountryAndLanguage>> GetPrimaryTranslationsAsync(
        CancellationToken cancellationToken = default);

    [Get("/configuration/timezones")]
    Task<IReadOnlyList<Timezone>> GetTimezonesAsync(
        CancellationToken cancellationToken = default);
}
