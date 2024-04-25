using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models.Keywords;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IKeywordProvider
{
    private IKeywordsApi? _keywordsApi;

    private IKeywordsApi KeywordsApi => this._keywordsApi ??= this.CreateRefitInterface<IKeywordsApi>();

    public async Task<Keyword> GetKeywordDetailsAsync(int keywordId, CancellationToken cancellationToken = default)
    {
        return await this.KeywordsApi.GetDetailsAsync(keywordId, cancellationToken)
            .ConfigureAwait(false);
    }
}
