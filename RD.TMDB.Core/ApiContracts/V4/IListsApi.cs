using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.V4.Lists;

namespace RD.TMDB.Core.ApiContracts.V4;

public interface IListsApi
{
    /// <summary>
    /// Retrieve a list by id.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/list/{listId}")]
    Task<ListDetail> GetDetailsAsync(
        int listId,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="addItemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Post("/list/{listId}/items")]
    Task<ItemsResponse> AddItemsAsync(
        int listId,
        [Body(BodySerializationMethod.Serialized)] ItemsRequest<ItemRequest> addItemsRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Clear all of the items on a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Get("/list/{listId}/clear")]
    Task<ClearResponse> ClearAsync(
        int listId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <param name="createRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Post("/list")]
    Task<CreateResponse> CreateAsync(
        [Body(BodySerializationMethod.Serialized)] CreateRequest createRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Delete("/list/{listId}")]
    Task<Response> DeleteAsync(
        int listId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Check if an item is on a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="mediaId"></param>
    /// <param name="mediaType"></param>
    /// <returns></returns>
    [Get("/list/{listId}/item_status")]
    Task<ItemStatus> CheckItemStatusAsync(
        int listId,
        [AliasAs("media_id")] int mediaId,
        [AliasAs("media_type")] string mediaType,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Delete("/list/{listId}/items")]
    Task<ItemsResponse> RemoveItemsAsync(
        int listId,
        [Body(BodySerializationMethod.Serialized)] ItemsRequest<ItemRequest> itemsRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the details of a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="updateRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Put("/list/{listId}")]
    Task<Response> UpdateAsync(
        int listId,
        [Body(BodySerializationMethod.Serialized)] UpdateRequest updateRequest,
        CancellationToken cancellationToken = default);

    [Put("/list/{listId}/items")]
    Task<ItemsResponse> UpdateItemsAsync(
        int listId,
        [Body(BodySerializationMethod.Serialized)] ItemsRequest<UpdateItemRequest> itemsRequest,
        CancellationToken cancellationToken = default);
}
