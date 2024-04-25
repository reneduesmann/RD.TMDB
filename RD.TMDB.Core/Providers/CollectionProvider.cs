using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Collections;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ICollectionProvider
{
    private ICollectionsApi? _collectionsApi;

    private ICollectionsApi CollectionsApi => this._collectionsApi ??= this.CreateRefitInterface<ICollectionsApi>();


    public async Task<CollectionDetail> GetCollectionDetailsAsync(int collectionId, Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.CollectionsApi.GetDetailsAsync(collectionId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Image> GetCollectionImagesAsync(int collectionId, IEnumerable<Iso639_1>? includeImageLanguages, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeImageLanuagesToUse = this.GetLanguages(includeImageLanguages);

        return await this.CollectionsApi
            .GetImagesAsync(collectionId, includeImageLanuagesToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TranslationContainer<TranslationData>> GetCollectionTranslationsAsync(int collectionId, CancellationToken cancellationToken = default)
    {
        return await this.CollectionsApi.GetTranslationsAsync(collectionId, cancellationToken).ConfigureAwait(false);
    }
}
