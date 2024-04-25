using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.AlternativeTitles;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Movies;
using RD.TMDB.Domain.Models.Reviews;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.ApiContracts;

public interface IMoviesApi
{
    /// <summary>
    /// Get a list of movies that are currently in theatres.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="region"></param>
    /// <returns></returns>
    [Get("/movie/now_playing")]
    Task<ResultDateContainer<Movie>> GetNowPlayingAsync(
        string? language = null,
        int? page = null,
        string? region = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies ordered by popularity.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="region"></param>
    /// <returns></returns>
    [Get("/movie/popular")]
    Task<ResultContainer<Movie>> GetPopularAsync(
        string? language = null,
        int? page = null,
        string? region = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies ordered by rating.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="region"></param>
    /// <returns></returns>
    [Get("/movie/top_rated")]
    Task<ResultContainer<Movie>> GetTopRatedAsync(
        string? language = null,
        int? page = null,
        string? region = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies that are being released soon.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="region"></param>
    /// <returns></returns>
    [Get("/movie/upcoming")]
    Task<ResultDateContainer<Movie>> GetUpcomingAsync(
        string? language = null,
        int? page = null,
        string? region = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the top level details of a movie by ID.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="appendToResponse">comma separated list of endpoints within this namespace, 20 items max.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}")]
    Task<MovieDetail> GetDetailsAsync(
        int movieId,
        [AliasAs("append_to_response"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? appendToResponse = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rating, watchlist and favourite status of an account.
    /// </summary>
    /// <param name="movieId"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/account_states")]
    Task<AccountState> GetAccountStateAsync(
        int movieId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the alternative titles for a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="country">specify a ISO-3166-1 value to filter the results.</param>
    /// <returns></returns>
    [Get("/movie/{movieId}/alternative_titles")]
    Task<AlternativeTitleContainer> GetAlternativeTitlesAsync(
        int movieId,
        string? country = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="page"></param>
    /// <remarks>
    /// Get the changes for a movie. By default only the last 24 hours are returned.
    /// You can query up to 14 days in a single query by using the start_date and end_date query parameters.
    /// </remarks>
    /// <returns></returns>
    [Get("/movie/{movieId}/changes")]
    Task<ChangeContainer> GetChangesAsync(
    int movieId,
    [AliasAs("start_date")] string? startDate = null,
    [AliasAs("end_date")] string? endDate = null,
    int? page = null,
        CancellationToken cancellationToken = default);

    [Get("/movie/{movieId}/credits")]
    Task<Credit<Cast, Crew>> GetCreditsAsync(
        int movieId,
        string? language = null,
        CancellationToken cancellationToken = default);

    [Get("/movie/{movieId}/external_ids")]
    Task<ExternalId> GetExternalIdsAsync(
        int movieId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: en,null.</param>
    /// <param name="language"></param>
    /// <returns>This method will return the backdrops, posters and logos that have been added to a movie.</returns>
    [Get("/movie/{movieId}/images")]
    Task<Image> GetImagesAsync(
        int movieId,
        [AliasAs("include_image_language"), Query(CollectionFormat.Csv)] IEnumerable<string>? includeImageLanguage = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    [Get("/movie/{movieId}/keywords")]
    Task<KeywordContainer> GetKeywordsAsync(
        int movieId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest movie ID.
    /// </summary>
    /// <returns></returns>
    [Get("/movie/latest")]
    Task<MovieDetail> GetLatestAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the lists that a movie has been added to.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/lists")]
    Task<ResultContainer<List>> GetListsAsync(
        int movieId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    [Get("/movie/{movieId}/recommendations")]
    Task<ResultContainer<Movie>> GetRecommendationsAsync(
        int movieId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the release dates and certifications for a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/release_dates")]
    Task<Result<ReleaseDateContainer>> GetReleaseDatesAsync(
        int movieId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user reviews for a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/reviews")]
    Task<ResultContainer<Review>> GetReviewsAsync(
        int movieId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the similar movies based on genres and keywords.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/similar")]
    Task<ResultContainer<Movie>> GetSimilarMoviesAsync(
        int movieId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations for a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/translations")]
    Task<TranslationContainer<MovieTranslationData>> GetTranslationsAsync(
        int movieId,
        CancellationToken cancellationToken = default);

    [Get("/movie/{movieId}/videos")]
    Task<Result<Video>> GetVideosAsync(
        int movieId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for a movie.
    /// </summary>
    /// <param name="movieId"></param>
    /// <returns></returns>
    [Get("/movie/{movieId}/watch/providers")]
    Task<WatchProviderContainer> GetWatchProvidersAsync(
        int movieId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Rate a movie and save it to your rated list.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="request"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Post("/movie/{movieId}/rating")]
    Task<Response> AddRatingAsync(
        int movieId,
        [Body(BodySerializationMethod.Serialized)] AddRatingRequest request,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user rating.
    /// </summary>
    /// <param name="movieId"></param>
    /// <param name="sessionId"></param>
    /// <param name="guestSessionId"></param>
    /// <returns></returns>
    [Delete("/movie/{movieId}/rating")]
    Task<Response> DeleteRatingAsync(
        int movieId,
        [AliasAs("session_id")] string? sessionId = null,
        [AliasAs("guest_session_id")] string? guestSessionId = null,
        CancellationToken cancellationToken = default);
}