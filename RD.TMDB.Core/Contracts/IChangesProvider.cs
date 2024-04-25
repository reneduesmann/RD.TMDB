using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;

namespace RD.TMDB.Core.Contracts;

public interface IChangesProvider
{
    Task<ResultContainer<ChangedItem>> GetMovieChangeListAsync(DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<ChangedItem>> GetPersonChangeListAsync(DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<ChangedItem>> GetTvShowChangeListAsync(DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
}