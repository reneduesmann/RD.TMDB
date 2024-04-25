using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models.Credits;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ICreditProvider
{
    private ICreditsApi? _creditsApi;

    private ICreditsApi CreditsApi => this._creditsApi ??= this.CreateRefitInterface<ICreditsApi>();

    public async Task<CreditDetail> GetCreditDetailsAsync(string creditId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(creditId);

        return await this.CreditsApi.GetDetailsAsync(creditId, cancellationToken).ConfigureAwait(false);
    }
}
