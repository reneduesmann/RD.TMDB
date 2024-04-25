using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvEpisodes;

namespace RD.TMDB.Core.ApiContracts;

public interface ITvEpisodesApi
{
    /// <summary>
    /// Query the details of a TV episode.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <param name="appendToResponse">comma separated list of endpoints within this namespace, 20 items max.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}")]
    Task<TvEpisodeDetail> GetDetailsAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        [AliasAs("append_to_response"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? appendToResponse = null,
        string? language = null, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/account_states")]
    Task<TvEpisodeAccountState> GetAccountStatesAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a TV episode.
    /// </summary>
    /// <param name="episodeId"></param>
    /// <returns></returns>
    [Get("/tv/episode/{episodeId}/changes")]
    Task<ChangeContainer> GetChangesAsync(
         int episodeId,
        CancellationToken cancellationToken = default);

    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/credits")]
    Task<Credit> GetCreditsAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV episode.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/external_ids")]
    Task<ExternalId> GetExternalIdsAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a TV episode.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: en,null.</param>
    /// <param name="language"></param>
    /// <returns>This method will return the backdrops that have been added to a TV episode.</returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/images")]
    Task<Image> GetImagesAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        [AliasAs("include_image_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeImageLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that have been added to a TV episode.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/translations")]
    Task<TranslationContainer<TvEpisodeTranslationData>> GetTranslationsAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the videos that belong to a TV episode.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/videos")]
    Task<Result<Video>> GetVideosAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        [AliasAs("include_video_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeVideoLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Rate a TV episode and save it to your rated list.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <param name="request"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Post("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/rating")]
    Task<Response> AddRatingAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        [Body(BodySerializationMethod.Serialized)] AddRatingRequest request,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete your rating on a TV episode.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="seasonNumber"></param>
    /// <param name="episodeNumber"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Delete("/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/rating")]
    Task<Response> DeleteRatingAsync(
        int seriesId,
        int seasonNumber,
        int episodeNumber,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);
}
