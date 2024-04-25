using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Persons;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Core.ApiContracts;

public interface IPersonsApi
{
    /// <summary>
    /// Get a list of people ordered by popularity.
    /// </summary>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/person/popular")]
    Task<ResultContainer<Person>> GetPopularAsync(
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Query the top level details of a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <param name="appendToResponse">comma separated list of endpoints within this namespace, 20 items max.</param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/person/{personId}")]
    Task<PersonDetail> GetDetailsAsync(
        int personId,
        [AliasAs("append_to_response"), Query(CollectionFormat = CollectionFormat.Csv)] IEnumerable<string>? appendToResponse = null,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="page"></param>
    /// <remarks>
    /// Get the changes for a person. By default only the last 24 hours are returned.
    /// You can query up to 14 days in a single query by using the start_date and end_date query parameters.
    /// </remarks>
    /// <returns></returns>
    [Get("/person/{personId}/changes")]
    Task<ChangeContainer> GetChangesAsync(
        int personId,
        [AliasAs("start_date")] string? startDate = null,
        [AliasAs("end_date")] string? endDate = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the combined movie and TV credits that belong to a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/person/{personId}/combined_credits")]
    Task<Credit<CombinedCast, CombinedCrew>> GetCombinedCreditsAsync(
        int personId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the external ID's that belong to a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <returns></returns>
    [Get("/person/{personId}/external_ids")]
    Task<ExternalId> GetExternalIdsAsync(
        int personId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the profile images that belong to a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <returns>This method will return the profile images that have been added to a person.</returns>
    [Get("/person/{personId}/images")]
    Task<PersonImage> GetImagesAsync(
        int personId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest created person. This is a live response and will continuously change.
    /// </summary>
    /// <returns></returns>
    [Get("/person/latest")]
    Task<PersonDetail> GetLatestAsync(
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the movie credits for a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/person/{personId}/movie_credits")]
    Task<Credit<MovieCast, MovieCrew>> GetMovieCreditsAsync(
        int personId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV credits that belong to a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/person/{personId}/tv_credits")]
    Task<Credit<TvShowCast, TvShowCrew>> GetTvShowCreditsAsync(
        int personId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that belong to a person.
    /// </summary>
    /// <param name="personId"></param>
    /// <returns></returns>
    [Get("/person/{personId}/translations")]
    Task<TranslationContainer<PersonTranslationData>> GetTranslationsAsync(
        int personId,
        CancellationToken cancellationToken = default);
}
