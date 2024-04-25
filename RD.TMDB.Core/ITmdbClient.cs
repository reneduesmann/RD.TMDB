using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core;
public interface ITmdbClient : IDisposable, IAccountProvider, IAuthenticationProvider, ICertificationProvider,
    IChangesProvider, ICollectionProvider, ICompanyProvider, IConfigurationProvider, ICreditProvider,
    IDiscoverProvider, IFindProvider, IGenreProvider, IGuestSessionProvider, IKeywordProvider, IListProvider,
    IMovieProvider, INetworkProvider, IPersonProvider, IReviewProvider, ISearchProvider, ITrendingProvider,
    ITvEpisodeGroupProvider, ITvEpisodeProvider, ITvSeasonProvider, ITvShowProvider, IWatchProviderProvider
{
    /// <summary>
    /// Default language to use for requests when not in the request specified.
    /// </summary>
    Iso639_1 DefaultLanguage { get; set; }

    /// <summary>
    /// Default country to use for requests when not in the request specified.
    /// </summary>
    Iso3166_1 DefaultCountry { get; set; }

    /// <summary>
    /// Get the content of the image from the specified <paramref name="filePath"/>.
    /// </summary>
    /// <param name="size"></param>
    /// <param name="filePath"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    Task<byte[]> GetImageAsync(string size, string filePath, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the video url for the specified <paramref name="video"/>.
    /// </summary>
    /// <param name="video"></param>
    /// <returns></returns>
    string GetVideoUrl(Video video);
}