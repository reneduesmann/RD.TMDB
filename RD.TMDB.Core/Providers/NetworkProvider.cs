using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Networks;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : INetworkProvider
{
    private INetworksApi? _networksApi;

    private INetworksApi NetworksApi => this._networksApi ??= this.CreateRefitInterface<INetworksApi>();

    public async Task<Result<AlternativeName>> GetAlternativeNetworkNamesAsync(int networkId, CancellationToken cancellationToken = default)
    {
        return await this.NetworksApi.GetAlternativeNamesAsync(networkId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<NetworkImageContainer> GetNetworkImagesAsync(int networkId, CancellationToken cancellationToken = default)
    {
        return await this.NetworksApi.GetImagesAsync(networkId, cancellationToken).ConfigureAwait(false);
    }
}
