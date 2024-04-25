using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.V4.Lists;

namespace RD.TMDB.Core.Contracts.V4;

public interface IListProvider
{
    /// <summary>
    /// Retrieve a list by id.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// Private lists can only be accessed by their owners and therefore require a valid user access token.
    /// </remarks>
    /// <returns></returns>
    Task<ListDetail> GetListDetailsAsync(int listId, Iso639_1? language = null,
        int? page = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> AddItemsToListAsync(int listId, ItemsRequest<ItemRequest> itemsRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemRequests"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> AddItemsToListAsync(int listId, List<ItemRequest> itemRequests,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="itemRequests"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> AddItemsToListAsync(int listId, CancellationToken cancellationToken = default,
        params ItemRequest[] itemRequests);

    /// <summary>
    /// Clear all of the items on a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ClearResponse> ClearListAsync(int listId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <param name="createRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// You will need to have valid user access token in order to create a new list.
    /// </remarks>
    /// <returns></returns>
    Task<CreateResponse> CreateListAsync(CreateRequest createRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="language"></param>
    /// <param name="public"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// You will need to have valid user access token in order to create a new list.
    /// </remarks>
    /// <returns></returns>
    Task<CreateResponse> CreateListAsync(string name, string language, bool @public,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="language"></param>
    /// <param name="public"></param>
    /// <param name="description"></param>
    /// <param name="country"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// You will need to have valid user access token in order to create a new list.
    /// </remarks>
    /// <returns></returns>
    Task<CreateResponse> CreateListAsync(string name, string language, bool @public, string? description,
        Iso3166_1? country, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Response> DeleteListAsync(int listId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Check if an item is on a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="mediaType"></param>
    /// <param name="mediaId"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// You must be the owner of the list and therefore have a valid user access token in order to check an item status.
    /// </remarks>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemStatus> CheckItemStatusAsync(int listId, MediaType mediaType, int mediaId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> RemoveItemsFromListAsync(int listId, ItemsRequest<ItemRequest> itemsRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemRequests"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> RemoveItemsFromListAsync(int listId, List<ItemRequest> itemRequests,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="itemRequests"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> RemoveItemsFromListAsync(int listId, CancellationToken cancellationToken = default,
        params ItemRequest[] itemRequests);

    /// <summary>
    /// Update the details of a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="updateRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Response> UpdateListAsync(int listId, UpdateRequest updateRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an individual item on a list,
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// Currently, only adding a comment is suported.
    /// </remarks>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> UpdateItemsInListAsync(int listId, ItemsRequest<UpdateItemRequest> itemsRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an individual item on a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemRequests"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// Currently, only adding a comment is suported.
    /// </remarks>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> UpdateItemsInListAsync(int listId, List<UpdateItemRequest> itemRequests,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Update an individual item on a list,
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="itemRequests"></param>
    /// <remarks>
    /// Currently, only adding a comment is suported.
    /// </remarks>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    Task<ItemsResponse> UpdateItemsInListAsync(int listId, CancellationToken cancellationToken = default,
        params UpdateItemRequest[] itemRequests);
}
