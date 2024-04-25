using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface ITrendingProvider
{
    Task<ResultContainer<IKnownFor>> GetAllTrendingAsync(TimeWindow timeWindow, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetTrendingMoviesAsync(TimeWindow timeWindow, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Person>> GetTrendingPersonsAsync(TimeWindow timeWindow, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> GetTrendingTvShowsAsync(TimeWindow timeWindow, Iso639_1? language = null, CancellationToken cancellationToken = default);
}