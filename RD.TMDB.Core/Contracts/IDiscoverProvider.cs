using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Requests;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface IDiscoverProvider
{
    Task<ResultContainer<Movie>> DiscoverMoviesAsync(DiscoverMovieRequest? discoverMovieRequest = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> DiscoverTvShowsAsync(DiscoverTvShowRequest? discoverTvShowRequest = null, CancellationToken cancellationToken = default);
}