using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Lists;

namespace RD.TMDB.Core.ApiContracts;

public interface IListsApi
{
    /// <summary>
    /// Add a movie to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="sessionId"></param>
    /// <param name="addMovieRequest"></param>
    /// <returns></returns>
    [Post("/list/{listId}/add_item")]
    Task<Response> AddMovieAsync(
        int listId,
        [AliasAs("session_id")] string sessionId,
        [Body(BodySerializationMethod.Serialized)] AddMovieRequest addMovieRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Use this method to check if an item has already been added to the list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="movieId"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    [Get("/list/{listId}/item_status")]
    Task<ItemStatus> CheckItemStatusAsync(
        int listId,
        [AliasAs("movie_id")] int movieId,
        string? language = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Clear all items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="sessionId"></param>
    /// <param name="confirm"></param>
    /// <returns></returns>
    [Post("/list/{listId}/clear")]
    Task<Response> ClearListAsync(
        int listId,
        [AliasAs("session_id")] string sessionId,
        string confirm,
        CancellationToken cancellationToken = default);

    [Post("/list")]
    Task<CreateListResponse> CreateListAsync(
        [AliasAs("session_id")] string sessionId,
        [Body(BodySerializationMethod.Serialized)] CreateListRequest createListRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="sessionId"></param>
    /// <returns></returns>
    [Delete("/list/{listId}")]
    Task<Response> DeleteListAsync(
        int listId,
        [AliasAs("session_id")] string sessionId,
        CancellationToken cancellationToken = default);

    [Get("/list/{listId}")]
    Task<ListDetail> GetDetailsAsync(
        int listId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a movie from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="sessionId"></param>
    /// <param name="removeMovieRequest"></param>
    /// <returns></returns>
    [Post("/list/{listId}/remove_item")]
    Task<Response> RemoveMovieAsync(
        int listId,
        [AliasAs("session_id")] string sessionId,
        [Body(BodySerializationMethod.Serialized)] RemoveMovieRequest removeMovieRequest,
        CancellationToken cancellationToken = default);
}
