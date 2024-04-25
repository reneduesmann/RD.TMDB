using RD.TMDB.Domain.Models.Credits;

namespace RD.TMDB.Core.Contracts;

public interface ICreditProvider
{
    Task<CreditDetail> GetCreditDetailsAsync(string creditId, CancellationToken cancellationToken = default);
}