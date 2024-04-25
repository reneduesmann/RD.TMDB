using RD.TMDB.Domain.Models.TvEpisodeGroups;

namespace RD.TMDB.Core.ApiContracts;

public interface ITvEpisodeGroupsApi
{
    /// <summary>
    /// Get the details of a TV episode group.
    /// </summary>
    /// <param name="groupId"></param>
    /// <returns></returns>
    [Get("/tv/episode_group/{groupId}")]
    Task<TvEpisodeGroupContainer> GetDetailsAsync(
        string groupId,
        CancellationToken cancellationToken = default);
}
