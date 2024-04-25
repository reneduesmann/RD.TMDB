using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Networks;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface INetworksApi
{
    [Get("/network/{networkId}")]
    Task<Network> GetDetailsAsync(
        int networkId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the alternative names of a network.
    /// </summary>
    /// <param name="networkId"></param>
    /// <returns></returns>
    [Get("/network/{networkId}/alternative_names")]
    Task<Result<AlternativeName>> GetAlternativeNamesAsync(
        int networkId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    /// <param name="networkId"></param>
    /// <returns></returns>
    [Get("/network/{networkId}/images")]
    Task<NetworkImageContainer> GetImagesAsync(
        int networkId,
        CancellationToken cancellationToken = default);
}
