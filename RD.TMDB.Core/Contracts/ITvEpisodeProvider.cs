using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvEpisodes;

namespace RD.TMDB.Core.Contracts;

public interface ITvEpisodeProvider
{
    Task<Response> AddTvEpisodeRatingAsync(int seriesId, int seasonNumber, int episodeNumber, double value, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<Response> DeleteTvEpisodeRatingAsync(int seriesId, int seasonNumber, int episodeNumber, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<TvEpisodeAccountState> GetTvEpisodeAccountStatesAsync(int seriesId, int seasonNumber, int episodeNumber, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<ChangeContainer> GetTvEpisodeChangesAsync(int episodeId, CancellationToken cancellationToken = default);
    
    Task<Credit> GetTvEpisodeCreditsAsync(int seriesId, int seasonNumber, int episodeNumber, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<TvEpisodeDetail> GetTvEpisodeDetailsAsync(int seriesId, int seasonNumber, int episodeNumber, TvEpisodeInformation additionalTvEpisodeInformations = TvEpisodeInformation.Undefined, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ExternalId> GetExternalTvEpisodeIdsAsync(int seriesId, int seasonNumber, int episodeNumber, CancellationToken cancellationToken = default);
    
    Task<Image> GetTvEpisodeImagesAsync(int seriesId, int seasonNumber, int episodeNumber, IReadOnlyList<Iso639_1>? includeImageLanguages = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<TranslationContainer<TvEpisodeTranslationData>> GetTvEpisodeTranslationsAsync(int seriesId, int seasonNumber, int episodeNumber, CancellationToken cancellationToken = default);
    
    Task<Result<Video>> GetTvEpisodeVideosAsync(int seriesId, int seasonNumber, int episodeNumber, IReadOnlyList<Iso639_1>? includeVideoLanguage = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
}