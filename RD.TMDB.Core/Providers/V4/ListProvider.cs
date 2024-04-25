using RD.TMDB.Core.ApiContracts.V4;
using RD.TMDB.Core.Contracts.V4;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.V4.Lists;

namespace RD.TMDB.Core.Providers.V4;

public sealed partial class TmdbV4Client : IListProvider
{
    private IListsApi? _listsApi;

    private IListsApi ListsApi => this._listsApi ??= this.CreateRefitInterface<IListsApi>();

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
    public async Task<ListDetail> GetListDetailsAsync(int listId, Iso639_1? language = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.ListsApi.GetDetailsAsync(listId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<ItemsResponse> AddItemsToListAsync(int listId, ItemsRequest<ItemRequest> itemsRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(itemsRequest);

        if (itemsRequest.Media is null || itemsRequest.Media.Count == 0)
        {
            throw new ArgumentException(nameof(itemsRequest.Media));
        }

        return await this.ListsApi.AddItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemRequests"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<ItemsResponse> AddItemsToListAsync(int listId, List<ItemRequest> itemRequests,
        CancellationToken cancellationToken = default)
    {
        if (itemRequests is null || itemRequests.Count == 0)
        {
            throw new ArgumentException(null, nameof(itemRequests));
        }

        ItemsRequest<ItemRequest> itemsRequest = new(itemRequests);

        return await this.ListsApi.AddItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="itemRequests"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<ItemsResponse> AddItemsToListAsync(int listId, CancellationToken cancellationToken = default,
        params ItemRequest[] itemRequests)
    {
        if (itemRequests is null || itemRequests.Length == 0)
        {
            throw new ArgumentException(null, nameof(itemRequests));
        }

        ItemsRequest<ItemRequest> itemsRequest = new([.. itemRequests]);

        return await this.ListsApi.AddItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Clear all of the items on a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ClearResponse> ClearListAsync(int listId, CancellationToken cancellationToken = default)
    {
        return await this.ListsApi.ClearAsync(listId, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <param name="createRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// You will need to have valid user access token in order to create a new list.
    /// </remarks>
    /// <returns></returns>
    public async Task<CreateResponse> CreateListAsync(CreateRequest createRequest, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(createRequest);

        return await this.ListsApi.CreateAsync(createRequest, cancellationToken)
            .ConfigureAwait(false);
    }

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
    public async Task<CreateResponse> CreateListAsync(string name, string language, bool @public,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(language);

        CreateRequest createRequest = new(name, language, @public);

        return await this.ListsApi.CreateAsync(createRequest, cancellationToken)
            .ConfigureAwait(false);
    }

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
    public async Task<CreateResponse> CreateListAsync(string name, string language, bool @public, string? description,
        Iso3166_1? country, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(language);

        CreateRequest createRequest = new(name, language, @public)
        {
            Description = description,
            Country = this.GetEnumValue(country)
        };

        return await this.ListsApi.CreateAsync(createRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Delete a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Response> DeleteListAsync(int listId, CancellationToken cancellationToken = default)
    {
        return await this.ListsApi.DeleteAsync(listId, cancellationToken)
            .ConfigureAwait(false);
    }

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
    public async Task<ItemStatus> CheckItemStatusAsync(int listId, MediaType mediaType, int mediaId,
        CancellationToken cancellationToken = default)
    {
        if (mediaType == MediaType.Undefined)
        {
            throw new ArgumentOutOfRangeException(nameof(mediaType));
        }

        string? mediaTypeToUse = this._enumCache.GetStringValue(mediaType);

        if(string.IsNullOrWhiteSpace(mediaTypeToUse))
        {
            throw new ArgumentException(null, nameof(mediaType));
        }

        return await this.ListsApi.CheckItemStatusAsync(listId, mediaId, mediaTypeToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<ItemsResponse> RemoveItemsFromListAsync(int listId, ItemsRequest<ItemRequest> itemsRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(itemsRequest);

        if (itemsRequest.Media is null || itemsRequest.Media.Count == 0)
        {
            throw new ArgumentException(null, nameof(itemsRequest));
        }

        return await this.ListsApi.RemoveItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="itemRequests"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<ItemsResponse> RemoveItemsFromListAsync(int listId, List<ItemRequest> itemRequests,
        CancellationToken cancellationToken = default)
    {
        if (itemRequests is null || itemRequests.Count == 0)
        {
            throw new ArgumentException(null, nameof(itemRequests));
        }

        ItemsRequest<ItemRequest> itemsRequest = new(itemRequests);

        return await this.ListsApi.RemoveItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Remove items from a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="itemRequests"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public async Task<ItemsResponse> RemoveItemsFromListAsync(int listId, CancellationToken cancellationToken = default,
        params ItemRequest[] itemRequests)
    {
        if (itemRequests is null || itemRequests.Length == 0)
        {
            throw new ArgumentException(null, nameof(itemRequests));
        }

        ItemsRequest<ItemRequest> itemsRequest = new([.. itemRequests]);

        return await this.ListsApi.RemoveItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Update the details of a list.
    /// </summary>
    /// <param name="listId"></param>
    /// <param name="updateRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Response> UpdateListAsync(int listId, UpdateRequest updateRequest, 
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(updateRequest);

        return await this.ListsApi.UpdateAsync(listId, updateRequest, cancellationToken)
            .ConfigureAwait(false);
    }

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
    public async Task<ItemsResponse> UpdateItemsInListAsync(int listId, ItemsRequest<UpdateItemRequest> itemsRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(itemsRequest);

        if (itemsRequest.Media is null || itemsRequest.Media.Count == 0)
        {
            throw new ArgumentException(null, nameof(itemsRequest));
        }

        return await this.ListsApi.UpdateItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

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
    public async Task<ItemsResponse> UpdateItemsInListAsync(int listId, List<UpdateItemRequest> itemRequests,
        CancellationToken cancellationToken = default)
    {
        if (itemRequests is null || itemRequests.Count == 0)
        {
            throw new ArgumentException(null, nameof(itemRequests));
        }

        ItemsRequest<UpdateItemRequest> itemsRequest = new(itemRequests);

        return await this.ListsApi.UpdateItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }

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
    public async Task<ItemsResponse> UpdateItemsInListAsync(int listId, CancellationToken cancellationToken = default,
        params UpdateItemRequest[] itemRequests)
    {
        if (itemRequests is null || itemRequests.Length == 0)
        {
            throw new ArgumentException(null, nameof(itemRequests));
        }

        ItemsRequest<UpdateItemRequest> itemsRequest = new([.. itemRequests]);

        return await this.ListsApi.UpdateItemsAsync(listId, itemsRequest, cancellationToken)
            .ConfigureAwait(false);
    }
}
