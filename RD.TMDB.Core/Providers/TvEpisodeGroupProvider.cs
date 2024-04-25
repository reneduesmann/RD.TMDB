using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models.TvEpisodeGroups;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ITvEpisodeGroupProvider
{
    private ITvEpisodeGroupsApi? _tvEpisodeGroupsApi;

    private ITvEpisodeGroupsApi TvEpisodeGroupsApi => this._tvEpisodeGroupsApi ??= this.CreateRefitInterface<ITvEpisodeGroupsApi>();

    public async Task<TvEpisodeGroupContainer> GetTvEpisodeGroupDetailsAsync(string groupId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(groupId);

        return await this.TvEpisodeGroupsApi.GetDetailsAsync(groupId, cancellationToken)
            .ConfigureAwait(false);
    }
}
