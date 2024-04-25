using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Discover;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.ApiContracts;

public interface IDiscoverApi
{
    /// <summary>
    /// Find movies using over 30 filters and sort options.
    /// </summary>
    /// <param name="discoverMovieQueryParameters">Parameters to filter the movies.</param>
    /// <remarks>
    /// Advanced Filtering
    /// If you specify the region parameter, the regional release date will be used instead of the primary release date.
    /// The date returned will be the first date based on your query (ie. if a with_release_type is specified). 
    /// It's important to note the order of the release types that are used. 
    /// Specifying 2|3 would return the limited theatrical release date as opposed to 3|2 which would return the theatrical date.
    /// 
    /// AND/OR Logic
    /// Also note that a number of filters support being comma (,) or pipe (|) separated. 
    /// Comma's are treated like an AND query while pipe's are treated like an OR. 
    /// This allows for quite complex filtering depending on your desired results.
    /// </remarks>
    /// <returns></returns>
    [Get("/discover/movie")]
    Task<ResultContainer<Movie>> DiscoverMoviesAsync(DiscoverMovieQueryParameters? discoverMovieQueryParameters = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Find TV shows using over 30 filters and sort options.
    /// </summary>
    /// <param name="discoverTvShowQueryParameters">Parameters to filter the tv shows.</param>
    /// <remarks>
    /// Advanced Filtering
    /// If you specify the region parameter, the regional release date will be used instead of the primary release date.
    /// The date returned will be the first date based on your query (ie. if a with_release_type is specified). 
    /// It's important to note the order of the release types that are used. 
    /// Specifying 2|3 would return the limited theatrical release date as opposed to 3|2 which would return the theatrical date.
    /// 
    /// AND/OR Logic
    /// Also note that a number of filters support being comma(,) or pipe(|) separated.
    /// Comma's are treated like an AND query while pipe's are treated like an OR.
    /// This allows for quite complex filtering depending on your desired results.
    /// </remarks>
    /// <returns></returns>
    [Get("/discover/tv")]
    Task<ResultContainer<TvShow>> DiscoverTvShowsAsync(DiscoverTvShowQueryParameters? discoverTvShowQueryParameters = null,
        CancellationToken cancellationToken = default);
}
