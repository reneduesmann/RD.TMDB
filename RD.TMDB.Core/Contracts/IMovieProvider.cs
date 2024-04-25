using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;
using RD.TMDB.Domain.Models.AlternativeTitles;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Movies;
using RD.TMDB.Domain.Models.Reviews;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.WatchProviders;

namespace RD.TMDB.Core.Contracts;

public interface IMovieProvider
{
    Task<Response> AddMovieRatingAsync(int movieId, AddRatingRequest addRatingRequest, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<Response> AddMovieRatingAsync(int movieId, double value, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<Response> DeleteMovieRatingAsync(int movieId, string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default);
    
    Task<AccountState> GetMovieAccountStateAsync(int movieId, CancellationToken cancellationToken = default);
    
    Task<AlternativeTitleContainer> GetAlternativeMovieTitlesAsync(int movieId, Iso3166_1? country = null, CancellationToken cancellationToken = default);
    
    Task<ChangeContainer> GetMovieChangesAsync(int movieId, DateOnly? startDate = null, DateOnly? endDate = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Credit<Cast, Crew>> GetMovieCreditsAsync(int movieId, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<MovieDetail> GetMovieDetailsAsync(int movieId, MovieInformation additionalMovieInformations = MovieInformation.Undefined, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<ExternalId> GetExternalMovieIdsAsync(int movieId, CancellationToken cancellationToken = default);
    
    Task<Image> GetMovieImagesAsync(int movieId, IReadOnlyList<Iso639_1>? includeImageLanguages = null, Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<KeywordContainer> GetMovieKeywordsAsync(int movieId, CancellationToken cancellationToken = default);
    
    Task<MovieDetail> GetLatestMovieAsync(CancellationToken cancellationToken = default);
    
    Task<ResultContainer<List>> GetMovieListsAsync(int movieId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultDateContainer<Movie>> GetNowPlayingMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetPopularMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetMovieRecommendationsAsync(int movieId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<Result<ReleaseDateContainer>> GetMovieReleaseDatesAsync(int movieId, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Review>> GetMovieReviewsAsync(int movieId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetSimilarMoviesAsync(int movieId, Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetTopRatedMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null, CancellationToken cancellationToken = default);
    
    Task<TranslationContainer<MovieTranslationData>> GetMovieTranslationsAsync(int movieId, CancellationToken cancellationToken = default);
    
    Task<ResultContainer<Movie>> GetUpcomingMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null, CancellationToken cancellationToken = default);
    
    Task<WatchProviderContainer> GetMovieWatchProvidersAsync(int movieId, CancellationToken cancellationToken = default);
}