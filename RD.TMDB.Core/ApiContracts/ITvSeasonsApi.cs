using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvSeasons;
using RD.TMDB.Domain.Models.TvShows;
using RD.TMDB.Domain.Models.WatchProviders;
using ExternalId = RD.TMDB.Domain.Models.TvSeasons.ExternalId;

namespace RD.TMDB.Core.ApiContracts;

public interface ITvSeasonsApi
{
    /// <summary>
    /// Query the details of a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="appendToResponse"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}")]
    Task<TvSeasonDetail> GetDetailsAsync(
        int seriesId,
        int seasonNumber,
        [AliasAs("append_to_response"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? appendToResponse = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/account_states")]
    Task<Result<TvSeasonAccountState>> GetAccountStatesAsync(
        int seriesId,
        int seasonNumber,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the aggregate credits (cast and crew) that have been added to a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/aggregate_credits")]
    Task<Credit<TvCast, TvCrew>> GetAggregateCreditsAsync(
        int seriesId,
        int seasonNumber,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="page"></param>
    /// <remarks>
    /// Get the changes for a TV season. By default only the last 24 hours are returned.
    /// You can query up to 14 days in a single query by using the start_date and end_date query parameters.
    /// </remarks>
    /// <returns></returns>
    [Get("/tv/season/{seasonId}/changes")]
    Task<ChangeContainer> GetChangesAsync(
        int seriesId,
        [AliasAs("start_date")] string? startDate = null,
        [AliasAs("end_date")] string? endDate = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    [Get("/tv/{seriesId}/season/{seasonNumber}/credits")]
    Task<Credit<Cast, Crew>> GetCreditsAsync(
        int seriesId,
        int seasonNumber,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/external_ids")]
    Task<ExternalId> GetExternalIdsAsync(
        int seriesId,
        int seasonNumber,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: en,null.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/images")]
    Task<Image> GetImagesAsync(
        int seriesId,
        int seasonNumber,
        [AliasAs("include_image_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeImageLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations for a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/translations")]
    Task<TranslationContainer<TvSeasonTranslationData>> GetTranslationsAsync(
        int seriesId,
        int seasonNumber,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the videos that belong to a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/videos")]
    Task<Result<Video>> GetVideosAsync(
        int seriesId,
        int seasonNumber,
        [AliasAs("include_video_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeVideoLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for a TV season.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/watch/providers")]
    Task<WatchProviderContainer> GetWatchProvidersAsync(
        int seriesId,
        int seasonNumber,
        string? language = null,
        CancellationToken cancellationToken = default);
}
