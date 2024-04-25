using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;

namespace RD.TMDB.Core.ApiContracts;

public interface IChangesApi
{
    /// <summary>
    /// Get a list of all of the movie ids that have been changed in the past 24 hours.
    /// </summary>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="page"></param>
    /// <remarks>
    /// You can query this method up to 14 days at a time. Use the start_date and end_date query parameters. 
    /// 100 items are returned per page.
    /// </remarks>
    /// <returns></returns>
    [Get("/movie/changes")]
    Task<ResultContainer<ChangedItem>> GetMovieChangeListAsync(
        [AliasAs("start_date")] string? startDate = null,
        [AliasAs("end_date")] string? endDate = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    [Get("/person/changes")]
    Task<ResultContainer<ChangedItem>> GetPersonChangeListAsync(
        [AliasAs("start_date")] string? startDate = null,
        [AliasAs("end_date")] string? endDate = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    [Get("/tv/changes")]
    Task<ResultContainer<ChangedItem>> GetTvShowChangeListAsync(
        [AliasAs("start_date")] string? startDate = null,
        [AliasAs("end_date")] string? endDate = null,
        int? page = null,
        CancellationToken cancellationToken = default);
}
