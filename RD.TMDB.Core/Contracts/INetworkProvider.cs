using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Networks;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface INetworkProvider
{
    Task<Result<AlternativeName>> GetAlternativeNetworkNamesAsync(int networkId, CancellationToken cancellationToken = default);
    
    Task<NetworkImageContainer> GetNetworkImagesAsync(int networkId, CancellationToken cancellationToken = default);
}