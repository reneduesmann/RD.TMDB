using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Searches;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface ISearchApi
{
    /// <summary>
    /// Search for collections by their original, translated and alternative names.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="includeAdult"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <param name="region"></param>
    /// <returns></returns>
    [Get("/search/collection")]
    Task<ResultContainer<SearchCollection>> SearchCollectionsAsync(
        string query,
        [AliasAs("include_adult")] bool? includeAdult = null,
        string? language = null,
        int? page = null,
        string? region = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for companies by their original and alternative names.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/search/company")]
    Task<ResultContainer<Company>> SearchCompaniesAsync(
        string query,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for keywords by their name.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/search/keyword")]
    Task<ResultContainer<Keyword>> SearchKeywordsAsync(
        string query,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for movies by their original, translated and alternative titles.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="searchMovieQueryParameters"></param>
    /// <returns></returns>
    [Get("/search/movie")]
    Task<ResultContainer<Movie>> SearchMoviesAsync(
        string query,
        SearchMovieQueryParameters? searchMovieQueryParameters = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Use multi search when you want to search for movies, TV shows and people in a single request.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="includeAdult"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/search/multi")]
    Task<ResultContainer<IKnownFor>> MultiSearchAsync(
        string query,
        [AliasAs("include_adult")] bool? includeAdult = null,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for people by their name and also known as names.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="includeAdult"></param>
    /// <param name="language"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    [Get("/search/person")]
    Task<ResultContainer<Person>> SearchPersonsAsync(
        string query,
        [AliasAs("include_adult")] bool? includeAdult = null,
        string? language = null,
        int? page = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for TV shows by their original, translated and also known as names.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="searchTvShowQueryParameters"></param>
    /// <returns></returns>
    [Get("/search/tv")]
    Task<ResultContainer<TvShow>> SearchTvShowsAsync(
        string query,
        SearchTvShowQueryParameters? searchTvShowQueryParameters = null,
        CancellationToken cancellationToken = default);
}
