using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;

namespace RD.TMDB.Core.ApiContracts;

public interface IGuestSessionsApi
{
    /// <summary>
    /// Get the rated movies for a guest session.
    /// </summary>
    /// <param name="guestSessionId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="sortBy"></param>
    /// <returns></returns>
    [Get("/guest_session/{guestSessionId}/rated/movies")]
    Task<ResultContainer<RatedMovie>> GetRatedMoviesAsync(
        string guestSessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rated TV shows for a guest session.
    /// </summary>
    /// <param name="guestSessionId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="sortBy"></param>
    /// <returns></returns>
    [Get("/guest_session/{guestSessionId}/rated/tv")]
    Task<ResultContainer<RatedTvShow>> GetRatedTvShowsAsync(
        string guestSessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rated TV episodes for a guest session.
    /// </summary>
    /// <param name="guestSessionId"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="sortBy"></param>
    /// <returns></returns>
    [Get("/guest_session/{guestSessionId}/rated/episodes")]
    Task<ResultContainer<RatedTvEpisode>> GetRatedTvEpisodesAsync(
        string guestSessionId,
        string? language = null,
        int? page = null,
        [AliasAs("sort_by")] string? sortBy = null,
        CancellationToken cancellationToken = default);
}
