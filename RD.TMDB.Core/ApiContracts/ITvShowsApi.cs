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

namespace RD.TMDB.Core.ApiContracts;

public interface ITvShowsApi
{
    /// <summary>
    /// Get a list of TV shows airing today.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="timezone"></param>
    /// <returns></returns>
    [Get("/tv/airing_today")]
    Task<ResultContainer<TvShow>> GetAiringTodayAsync(
        string? language = null,
        int? page = null,
        string? timezone = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows that air in the next 7 days.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="timezone"></param>
    /// <returns></returns>
    [Get("/tv/on_the_air")]
    Task<ResultContainer<TvShow>> GetOnTheAirAsync(
        string? language = null,
        int? page = null,
        string? timezone = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows ordered by popularity.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/tv/popular")]
    Task<ResultContainer<TvShow>> GetPopularAsync(
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows ordered by rating.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/tv/top_rated")]
    Task<ResultContainer<TvShow>> GetTopRatedAsync(
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the details of a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="appendToResponse">comma separated list of endpoints within this namespace, 20 items max.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}")]
    Task<TvShowDetail> GetDetailsAsync(
        int seriesId,
        [AliasAs("append_to_response"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? appendToResponse = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/account_states")]
    Task<AccountState> GetAccountStatesAsync(
        int seriesId,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the aggregate credits (cast and crew) that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/aggregate_credits")]
    Task<Credit<TvCast, TvCrew>> GetAggregateCreditsAsync(
        int seriesId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the alternative titles that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/alternative_titles")]
    Task<Result<AlternativeTitle>> GetAlternativeTitlesAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="page"></param>
    /// <remarks>
    /// Get the changes for a TV show. By default only the last 24 hours are returned.
    /// You can query up to 14 days in a single query by using the start_date and end_date query parameters.
    /// </remarks>
    /// <returns></returns>
    [Get("/tv/{seriesId}/changes")]
    Task<ChangeContainer> GetChangesAsync(
    int seriesId,
    [AliasAs("start_date")] string? startDate = null,
    [AliasAs("end_date")] string? endDate = null,
    int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the content ratings that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/content_ratings")]
    Task<Result<ContentRating>> GetContentRatingsAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the latest season credits of a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/credits")]
    Task<Credit<Cast, Crew>> GetCreditsAsync(
        int seriesId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the episode groups that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/episode_groups")]
    Task<Result<TvEpisodeGroup>> GetEpisodeGroupsAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/external_ids")]
    Task<ExternalId> GetExternalIdsAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a TV series.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="includeImageLanguage"></param>
    /// <param name="language"></param>
    /// <returns>This method will return the backdrops, posters and logos that have been added to a TV show.</returns>
    [Get("/tv/{seriesId}/images")]
    Task<Image> GetImagesAsync(
        int seriesId,
        [AliasAs("include_image_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeImageLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of keywords that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/keywords")]
    Task<Result<Keyword>> GetKeywordsAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest TV show ID.
    /// </summary>
    /// <returns></returns>
    [Get("/tv/latest")]
    Task<TvShowDetail> GetLatestAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the lists that a TV series has been added to.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/lists")]
    Task<ResultContainer<List>> GetListsAsync(
        int seriesId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    [Get("/tv/{seriesId}/recommendations")]
    Task<ResultContainer<TvShow>> GetRecommendationsAsync(
        int seriesId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the reviews that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/reviews")]
    Task<ResultContainer<Review>> GetReviewsAsync(
        int seriesId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the seasons and episodes that have screened theatrically.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/screened_theatrically")]
    Task<Result<ScreenedTheatrically>> GetScreenedTheatricallyAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the similar TV shows.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/similar")]
    Task<ResultContainer<TvShow>> GetSimilarAsync(
        int seriesId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that have been added to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/translations")]
    Task<TranslationContainer<TvShowTranslationData>> GetTranslationsAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the videos that belong to a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/videos")]
    Task<Result<Video>> GetVideosAsync(
        int seriesId,
        [AliasAs("include_video_language"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? includeVideoLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for a TV show.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <returns></returns>
    [Get("/tv/{seriesId}/watch/providers")]
    Task<WatchProviderContainer> GetWatchProvidersAsync(
        int seriesId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Rate a TV show and save it to your rated list.
    /// </summary>
    /// <param name="seriesId"></param>
    /// <param name="request"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Post("/tv/{seriesId}/rating")]
    Task<Response> AddRatingAsync(
        int seriesId,
        [Body(BodySerializationMethod.Serialized)] AddRatingRequest request,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);

    [Delete("/tv/{seriesId}/rating")]
    Task<Response> DeleteRatingAsync(
        int seriesId,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);
}
