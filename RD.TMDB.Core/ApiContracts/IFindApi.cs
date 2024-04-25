using RD.TMDB.Domain.Models.Finds;

namespace RD.TMDB.Core.ApiContracts;

public interface IFindApi
{
    /// <summary>
    /// Find data by external ID's.
    /// </summary>
    /// <param name="externalId"></param>
    /// <param name="externalSource"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/find/{externalId}")]
    Task<Find> FindByIdAsync(
        string externalId,
        [AliasAs("external_source")] string externalSource,
        string? language = null,
        CancellationToken cancellationToken = default);
}
