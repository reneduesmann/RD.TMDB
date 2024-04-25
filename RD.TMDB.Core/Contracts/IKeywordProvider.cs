using RD.TMDB.Domain.Models.Keywords;

namespace RD.TMDB.Core.Contracts;

public interface IKeywordProvider
{
    Task<Keyword> GetKeywordDetailsAsync(int keywordId, CancellationToken cancellationToken = default);
}