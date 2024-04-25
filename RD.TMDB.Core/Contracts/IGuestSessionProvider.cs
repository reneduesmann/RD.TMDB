using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;

namespace RD.TMDB.Core.Contracts;

public interface IGuestSessionProvider
{
    Task<ResultContainer<RatedMovie>> GetGuestRatedMoviesAsync(string guestSessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<RatedTvEpisode>> GetGuestRatedTvEpisodesAsync(string guestSessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<RatedTvShow>> GetGuestRatedTvShowsAsync(string guestSessionId, Iso639_1? language = null, int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default);
}