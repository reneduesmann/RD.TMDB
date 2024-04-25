using RD.TMDB.Domain.Models.Collections;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Core.ApiContracts;

public interface ICollectionsApi
{
    /// <summary>
    /// Get collection details by ID.
    /// </summary>
    /// <param name="collectionId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/collection/{collectionId}")]
    Task<CollectionDetail> GetDetailsAsync(
        int collectionId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a collection.
    /// </summary>
    /// <param name="collectionId"></param>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: en,null.</param>
    /// <remarks>
    /// If you have a language specified, it will act as a filter on the returned items. 
    /// You can use the includeImageLanguage param to query additional languages.
    /// </remarks>
    /// <returns>This method will return the backdrops and posters that have been added to a collection.</returns>
    [Get("/collection/{collectionId}/images")]
    Task<Image> GetImagesAsync(
        int collectionId,
        [AliasAs("include_image_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeImageLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    [Get("/collection/{collectionId}/translations")]
    Task<TranslationContainer<TranslationData>> GetTranslationsAsync(
        int collectionId,
        CancellationToken cancellationToken = default);
}
