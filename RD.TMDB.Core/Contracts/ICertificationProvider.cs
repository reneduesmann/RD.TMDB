using RD.TMDB.Domain.Models.Certifications;

namespace RD.TMDB.Core.Contracts;

public interface ICertificationProvider
{
    Task<CertificationContainer> GetMovieCertificationsAsync(CancellationToken cancellationToken = default);
    
    Task<CertificationContainer> GetTvShowCertificationsAsync(CancellationToken cancellationToken = default);
}