using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ICompanyProvider
{
    private ICompaniesApi? _companiesApi;

    private ICompaniesApi CompaniesApi => this._companiesApi ??= this.CreateRefitInterface<ICompaniesApi>();

    public async Task<CompanyDetail> GetCompanyDetailsAsync(int companyId, CancellationToken cancellationToken = default)
    {
        return await this.CompaniesApi.GetDetailsAsync(companyId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Result<AlternativeName>> GetAlternativeCompanyNamesAsync(int companyId, CancellationToken cancellationToken = default)
    {
        return await this.CompaniesApi.GetAlternativeNamesAsync(companyId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<CompanyImageContainer> GetCompanyImagesAsync(int companyId, CancellationToken cancellationToken = default)
    {
        return await this.CompaniesApi.GetImagesAsync(companyId, cancellationToken).ConfigureAwait(false);
    }
}
