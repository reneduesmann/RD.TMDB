using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.Contracts;

public interface IWatchProviderProvider
{
    Task<Result<Region>> GetAvailableRegionsAsync(Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<Result<Provider>> GetMovieProvidersAsync(Iso639_1? language = null, Iso3166_1? watchRegion = null, CancellationToken cancellationToken = default);
    
    Task<Result<Provider>> GetTvShowProvidersAsync(Iso639_1? language = null, Iso3166_1? watchRegion = null, CancellationToken cancellationToken = default);
}