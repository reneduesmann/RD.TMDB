using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models.Certifications;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ICertificationProvider
{
    private ICertificationsApi? _certificationsApi;

    private ICertificationsApi CertificationsApi => this._certificationsApi ??= this.CreateRefitInterface<ICertificationsApi>();

    public async Task<CertificationContainer> GetMovieCertificationsAsync(CancellationToken cancellationToken = default)
    {
        return await this.CertificationsApi.GetMovieCertificationsAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<CertificationContainer> GetTvShowCertificationsAsync(CancellationToken cancellationToken = default)
    {
        return await this.CertificationsApi.GetTvShowCertificationsAsync(cancellationToken).ConfigureAwait(false);
    }
}
