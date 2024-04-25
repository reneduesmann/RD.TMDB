using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Lists;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IListProvider
{
    private IListsApi? _listsApi;

    private IListsApi ListsApi => this._listsApi ??= this.CreateRefitInterface<IListsApi>();

    public async Task<Response> AddMovieToListAsync(int listId, string sessionId, int mediaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        AddMovieRequest addMovieRequest = new(mediaId);

        return await this.ListsApi.AddMovieAsync(listId, sessionId, addMovieRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ItemStatus> CheckItemStatusAsync(int listId, int movieId, Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.ListsApi.CheckItemStatusAsync(listId, movieId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> ClearListAsync(int listId, string sessionId, bool confirm, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        string confirmToUse = confirm ? "true" : "false";

        return await this.ListsApi.ClearListAsync(listId, sessionId, confirmToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<CreateListResponse> CreateListAsync(string sessionId, string name, string? description, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        string? languageToUse = this.GetLanguage(language);

        CreateListRequest createListRequest = new(name) { Description = description, Language = languageToUse };

        return await this.ListsApi.CreateListAsync(sessionId, createListRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<CreateListResponse> CreateListAsync(string sessionId, CreateListRequest createListRequest,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);
        ArgumentNullException.ThrowIfNull(createListRequest);
        ArgumentException.ThrowIfNullOrWhiteSpace(createListRequest.Name);

        return await this.ListsApi.CreateListAsync(sessionId, createListRequest, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> DeleteListAsync(int listId, string sessionId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        return await this.ListsApi.DeleteListAsync(listId, sessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ListDetail> GetListDetailsAsync(int listId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.ListsApi.GetDetailsAsync(listId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> RemoveMovieFromListAsync(int listId, string sessionId, int mediaId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(sessionId);

        RemoveMovieRequest removeMovieRequest = new(mediaId);

        return await this.ListsApi.RemoveMovieAsync(listId, sessionId, removeMovieRequest, cancellationToken)
            .ConfigureAwait(false);
    }
}
