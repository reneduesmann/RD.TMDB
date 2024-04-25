using RD.TMDB.Domain.Models.Certifications;

namespace RD.TMDB.Core.ApiContracts;

public interface ICertificationsApi
{
    /// <summary>
    /// Get an up to date list of the officially supported movie certifications on TMDB.
    /// </summary>
    /// <returns></returns>
    [Get("/certification/movie/list")]
    Task<CertificationContainer> GetMovieCertificationsAsync(CancellationToken cancellationToken = default);

    [Get("/certification/tv/list")]
    Task<CertificationContainer> GetTvShowCertificationsAsync(
        CancellationToken cancellationToken = default);
}
