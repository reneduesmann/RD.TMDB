using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Finds;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IFindProvider
{
    private IFindApi? _findApi;

    private IFindApi FindApi => this._findApi ??= this.CreateRefitInterface<IFindApi>();

    public async Task<Find> FindByIdAsync(string externalId, ExternalSource externalSource, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(externalId);

        string? languageToUse = this.GetLanguage(language);
        string? externalSourceToUse = this._enumCache.GetStringValue(externalSource);

        if (string.IsNullOrWhiteSpace(externalSourceToUse))
        {
            throw new ArgumentException(string.Format(InvalidExternalSource, externalSource));
        }

        return await this.FindApi.FindByIdAsync(externalId, externalSourceToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }
}
