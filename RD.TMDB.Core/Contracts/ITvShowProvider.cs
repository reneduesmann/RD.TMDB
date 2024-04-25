using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.AlternativeTitles;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Reviews;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvShows;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.Contracts;

public interface ITvShowProvider
{
    Task<Response> AddTvShowRatingAsync(int seriesId, double value, string? sessionId, string? guestSession = null, CancellationToken cancellationToken = default);
    
    Task<Response> DeleteTvShowRatingAsync(int seriesId, string? sessionId, string? guestSession = null, CancellationToken cancellationToken = default);
    
    Task<AccountState> GetTvShowAccountStatesAsync(int serieSId, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<Credit<TvCast, TvCrew>> GetAggregateTvShowCreditsAsync(int seriesId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetAiringTvShowsTodayAsync(Iso639_1? language = null, int? page = null, string? timezone = null, CancellationToken cancellationToken = default);
    
    Task<Result<AlternativeTitle>> GetAlternativeTvShowTitlesAsync(int serisId, CancellationToken cancellationToken = default);
    
    Task<ChangeContainer> GetTvShowChangesAsync(int seriesId, DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Result<ContentRating>> GetContentTvShowRatingsAsync(int seriesId, CancellationToken cancellationToken = default);
    
    Task<Credit<Cast, Crew>> GetTvShowCreditsAsync(int seriesId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<TvShowDetail> GetTvShowDetailsAsync(int seriesId, TvShowInformation additionalTvShowInformations = TvShowInformation.Undefined, Iso639_1? language = null, IReadOnlyList<int>? additionalTvSeasonInformations = null, CancellationToken cancellationToken = default);
    
    Task<Result<TvEpisodeGroup>> GetTvShowEpisodeGroupsAsync(int seriesId, CancellationToken cancellationToken = default);
    
    Task<ExternalId> GetExternalTvShowIdsAsync(int seriesId, CancellationToken cancellationToken = default);
    
    Task<Image> GetTvShowImagesAsync(int seriesId, IReadOnlyList<Iso639_1>? includeImageLanguages = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<Result<Keyword>> GetTvShowKeywordsAsync(int seriesId, CancellationToken cancellationToken = default);
    
    Task<TvShowDetail> GetLatestTvShowAsync(CancellationToken cancellationToken = default);
    
    Task<ResultContainer<List>> GetTvShowListsAsync(int seriesId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetOnTheAirTvShowsAsync(Iso639_1? language = null, int? page = null, string? timezone = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetPopularTvShowsAsync(Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetTvShowRecommendationsAsync(int seriesId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Review>> GetTvShowReviewsAsync(int seriesId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Result<ScreenedTheatrically>> GetScreenedTheatricallyTvShowsAsync(int seriesId, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetSimilarTvShowsAsync(int seriesId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetTopRatedTvShowsAsync(Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<TranslationContainer<TvShowTranslationData>> GetTvShowTranslationsAsync(int seriesId, CancellationToken cancellationToken = default);
    
    Task<Result<Video>> GetTvShowVideosAsync(int seriesId, IReadOnlyList<Iso639_1>? includeVideoLanguage = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<WatchProviderContainer> GetTvShowWatchProvidersAsync(int seriesId, CancellationToken cancellationToken = default);
}