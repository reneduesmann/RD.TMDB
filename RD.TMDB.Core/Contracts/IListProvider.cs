using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Lists;

namespace RD.TMDB.Core.Contracts;

public interface IListProvider
{
    Task<Response> AddMovieToListAsync(int listId, string sessionId, int mediaId, CancellationToken cancellationToken = default);
    
    Task<ItemStatus> CheckItemStatusAsync(int listId, int movieId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<Response> ClearListAsync(int listId, string sessionId, bool confirm, CancellationToken cancellationToken = default);
    
    Task<CreateListResponse> CreateListAsync(string sessionId, CreateListRequest createListRequest, CancellationToken cancellationToken = default);
    
    Task<CreateListResponse> CreateListAsync(string sessionId, string name, string? description, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<Response> DeleteListAsync(int listId, string sessionId, CancellationToken cancellationToken = default);
    
    Task<ListDetail> GetListDetailsAsync(int listId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Response> RemoveMovieFromListAsync(int listId, string sessionId, int mediaId, CancellationToken cancellationToken = default);
}