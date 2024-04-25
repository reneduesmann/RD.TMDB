using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Requests;
using RD.TMDB.Domain.Models.Searches;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Contracts;

public interface ISearchProvider
{
    Task<ResultContainer<IKnownFor>> MultiSearchAsync(string query, bool? includeAdult = null, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<SearchCollection>> SearchCollectionsAsync(string query, bool? includeAdult = null, Iso639_1? language = null, int? page = null, Iso3166_1? region = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Company>> SearchCompaniesAsync(string query, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Keyword>> SearchKeywordsAsync(string query, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> SearchMoviesAsync(string query, SearchMovieRequest? searchMovieRequest = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Person>> SearchPersonsAsync(string query, bool? includeAdult = null, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<TvShow>> SearchTvShowsAsync(string query, SearchTvShowRequest? searchTvShowRequest = null, CancellationToken cancellationToken = default);
}