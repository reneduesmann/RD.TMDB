using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Collections;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Core.Contracts;

public interface ICollectionProvider
{
    Task<CollectionDetail> GetCollectionDetailsAsync(int collectionId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<Image> GetCollectionImagesAsync(int collectionId, IEnumerable<Iso639_1>? includeImageLanguages, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<TranslationContainer<TranslationData>> GetCollectionTranslationsAsync(int collectionId, CancellationToken cancellationToken = default);
}