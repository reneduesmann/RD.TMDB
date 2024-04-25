using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface ICompaniesApi
{
    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    /// <param name="companyId"></param>
    /// <returns></returns>
    [Get("/company/{companyId}")]
    Task<CompanyDetail> GetDetailsAsync(
        int companyId,
        CancellationToken cancellationToken = default);

    [Get("/company/{companyId}/alternative_names")]
    Task<Result<AlternativeName>> GetAlternativeNamesAsync(
        int companyId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    /// <param name="companyId"></param>
    /// <returns></returns>
    [Get("/company/{companyId}/images")]
    Task<CompanyImageContainer> GetImagesAsync(
        int companyId,
        CancellationToken cancellationToken = default);
}
