using RD.TMDB.Domain.Models.Keywords;

namespace RD.TMDB.Core.ApiContracts;

public interface IKeywordsApi
{
    [Get("/keyword/{keywordId}")]
    Task<Keyword> GetDetailsAsync(int keywordId,
        CancellationToken cancellationToken = default);
}
