using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvSeasons;
using RD.TMDB.Domain.Models.TvShows;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.Contracts;

public interface ITvSeasonProvider
{
    Task<Result<TvSeasonAccountState>> GetTvSeasonAccountStatesAsync(int serisId, int seasonNumber, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<Credit<TvCast, TvCrew>> GetAggregateTvSeasonCreditsAsync(int seriesId, int seasonNumber, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ChangeContainer> GetTvSeasonChangesAsync(int seriesId, DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Credit<Cast, Crew>> GetTvSeasonCreditsAsync(int seriesId, int seasonNumber, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<TvSeasonDetail> GetTvSeasonDetailsAsync(int seriesId, int seasonNumber, TvSeasonInformation additionalTvSeasonInformations = TvSeasonInformation.Undefined, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<Domain.Models.TvSeasons.ExternalId> GetExternalTvSeasonIdsAsync(int seriesId, int seasonNumber, CancellationToken cancellationToken = default);
    
    Task<Image> GetTvSeasonImagesAsync(int seriesId, int seasonNumber, IReadOnlyList<Iso639_1>? includeImageLanguages = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<TranslationContainer<TvSeasonTranslationData>> GetTvSeasonTranslationsAsync(int seriesId, int seasonNumber, CancellationToken cancellationToken = default);
    
    Task<Result<Video>> GetTvSeasonVideosAsync(int seriesId, int seasonNumber, IReadOnlyList<Iso639_1>? includeVideoLanguage = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<WatchProviderContainer> GetTvSeasonWatchProvidersAsync(int seriesId, int seasonNumber, Iso639_1? language = null, CancellationToken cancellationToken = default);
}