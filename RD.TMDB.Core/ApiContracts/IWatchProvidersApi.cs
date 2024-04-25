using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.ApiContracts;

public interface IWatchProvidersApi
{
    /// <summary>
    /// Get the list of the countries we have watch provider (OTT/streaming) data for.
    /// </summary>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/watch/providers/regions")]
    Task<Result<Region>> GetAvailableRegionsAsync(
        string? language = null, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for movies.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="watchRegion"></param>
    /// <returns>Returns a list of the watch provider (OTT/streaming) data we have available for movies. 
    /// You can specify a watch_region param if you want to further filter the list by country.</returns>
    [Get("/watch/providers/movie")]
    Task<Result<Provider>> GetMovieProvidersAsync(
        string? language = null,
        [AliasAs("watch_region")] string? watchRegion = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for TV shows.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="watchRegion"></param>
    /// <returns>Returns a list of the watch provider (OTT/streaming) data we have available for TV shows. 
    /// You can specify a watch_region param if you want to further filter the list by country.</returns>
    [Get("/watch/providers/tv")]
    Task<Result<Provider>> GetTvShowProvidersAsync(
        string? language = null,
        [AliasAs("watch_region")] string? watchRegion = null,
        CancellationToken cancellationToken = default);
}
