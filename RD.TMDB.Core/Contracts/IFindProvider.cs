using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Finds;

namespace RD.TMDB.Core.Contracts;

public interface IFindProvider
{
    Task<Find> FindByIdAsync(string externalId, ExternalSource externalSource, Iso639_1? language = null, CancellationToken cancellationToken = default);
}