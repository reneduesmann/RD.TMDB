using RD.TMDB.Domain.Models.Credits;

namespace RD.TMDB.Core.ApiContracts;

public interface ICreditsApi
{
    /// <summary>
    /// Get a movie or TV credit details by ID.
    /// </summary>
    /// <param name="creditId"></param>
    /// <returns></returns>
    [Get("/credit/{credit_id}")]
    Task<CreditDetail> GetDetailsAsync(
        [AliasAs("credit_id")] string creditId,
        CancellationToken cancellationToken = default);
}
