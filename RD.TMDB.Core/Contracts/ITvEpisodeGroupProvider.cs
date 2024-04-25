using RD.TMDB.Domain.Models.TvEpisodeGroups;

namespace RD.TMDB.Core.Contracts;

public interface ITvEpisodeGroupProvider
{
    Task<TvEpisodeGroupContainer> GetTvEpisodeGroupDetailsAsync(string groupId, CancellationToken cancellationToken = default);
}