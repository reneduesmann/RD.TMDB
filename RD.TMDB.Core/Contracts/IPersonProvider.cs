using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Persons;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Core.Contracts;

public interface IPersonProvider
{
    Task<ChangeContainer> GetPersonChangesAsync(int personId, DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Credit<CombinedCast, CombinedCrew>> GetCombinedPersonCreditsAsync(int personId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<PersonDetail> GetPersonDetailsAsync(int personId, PersonInformation additionalPersonInformation = PersonInformation.Undefined, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ExternalId> GetExternalPersonIdsAsync(int personId, CancellationToken cancellationToken = default);
    
    Task<PersonImage> GetPersonImagesAsync(int personId, CancellationToken cancellationToken = default);
    
    Task<PersonDetail> GetLatestPersonAsync(CancellationToken cancellationToken = default);
    
    Task<Credit<MovieCast, MovieCrew>> GetPersonMovieCreditsAsync(int personId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Person>> GetPopularPersonsAsync(Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<TranslationContainer<PersonTranslationData>> GetPersonTranslationsAsync(int personId, CancellationToken cancellationToken = default);
    
    Task<Credit<TvShowCast, TvShowCrew>> GetPersonTvShowCreditsAsync(int personId, Iso639_1? language = null, CancellationToken cancellationToken = default);
}