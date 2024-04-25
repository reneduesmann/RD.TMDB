using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Configurations;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface IConfigurationProvider
{
    Task<ApiConfiguration> GetApiConfigurationAsync(CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<Country>> GetCountriesAsync(string? language = null, CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<Job>> GetJobsAsync(CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<Language>> GetLanguagesAsync(CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<CountryAndLanguage>> GetPrimaryTranslationsAsync(CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<Timezone>> GetTimezonesAsync(CancellationToken cancellationToken = default);
}