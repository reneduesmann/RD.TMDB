using RD.TMDB.Core.Contracts.Factories;

namespace RD.TMDB.Core.Implementations.Factories;

public sealed class RefitApiFactory : IRefitApiFactory
{
    private readonly HttpClient _httpClient;

    private readonly RefitSettings _refitSettings;

    public RefitApiFactory(HttpClient httpClient, RefitSettings refitSettings)
    {
        this._httpClient = httpClient;
        this._refitSettings = refitSettings;
    }

    public TApi CreateClient<TApi>()
    {
        return RestService.For<TApi>(this._httpClient, this._refitSettings);
    }
}
