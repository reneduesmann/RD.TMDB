using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface ICompanyProvider
{
    Task<Result<AlternativeName>> GetAlternativeCompanyNamesAsync(int companyId, CancellationToken cancellationToken = default);
    
    Task<CompanyDetail> GetCompanyDetailsAsync(int companyId, CancellationToken cancellationToken = default);
    
    Task<CompanyImageContainer> GetCompanyImagesAsync(int companyId, CancellationToken cancellationToken = default);
}