using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
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
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IMovieProvider
{
    private IMoviesApi? _moviesApi;

    private IMoviesApi MoviesApi => this._moviesApi ??= this.CreateRefitInterface<IMoviesApi>();

    public async Task<ResultDateContainer<Movie>> GetNowPlayingMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);
        string? regionToUse = this.GetEnumValue(region);

        return await this.MoviesApi.GetNowPlayingAsync(languageToUse, page, regionToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetPopularMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);
        string? regionToUse = this.GetEnumValue(region);

        return await this.MoviesApi.GetPopularAsync(languageToUse, page, regionToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetTopRatedMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);
        string? regionToUse = this.GetEnumValue(region);

        return await this.MoviesApi.GetTopRatedAsync(languageToUse, page, regionToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetUpcomingMoviesAsync(Iso639_1? language = null, int? page = null, Iso3166_1? region = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);
        string? regionToUse = this.GetEnumValue(region);

        return await this.MoviesApi.GetUpcomingAsync(languageToUse, page, regionToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<MovieDetail> GetMovieDetailsAsync(int movieId, MovieInformation additionalMovieInformations = MovieInformation.Undefined,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        List<string> additionalInformations = this.GetAdditionalInformations(additionalMovieInformations);

        return await this.MoviesApi.GetDetailsAsync(movieId, additionalInformations, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<AccountState> GetMovieAccountStateAsync(int movieId, CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetAccountStateAsync(movieId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<AlternativeTitleContainer> GetAlternativeMovieTitlesAsync(int movieId, Iso3166_1? country = null,
        CancellationToken cancellationToken = default)
    {
        string? countryToUse = this.GetCountry(country);

        return await this.MoviesApi.GetAlternativeTitlesAsync(movieId, countryToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ChangeContainer> GetMovieChangesAsync(int movieId, DateOnly? startDate = null, DateOnly? endDate = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.MoviesApi.GetChangesAsync(movieId, startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<Cast, Crew>> GetMovieCreditsAsync(int movieId, Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.MoviesApi.GetCreditsAsync(movieId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ExternalId> GetExternalMovieIdsAsync(int movieId, CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetExternalIdsAsync(movieId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Image> GetMovieImagesAsync(int movieId, IReadOnlyList<Iso639_1>? includeImageLanguages = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeImageLanguagesToUse = this.GetLanguages(includeImageLanguages);

        return await this.MoviesApi.GetImagesAsync(movieId, includeImageLanguagesToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<KeywordContainer> GetMovieKeywordsAsync(int movieId, CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetKeywordsAsync(movieId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<MovieDetail> GetLatestMovieAsync(CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetLatestAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResultContainer<List>> GetMovieListsAsync(int movieId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.MoviesApi.GetListsAsync(movieId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetMovieRecommendationsAsync(int movieId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.MoviesApi.GetRecommendationsAsync(movieId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<ReleaseDateContainer>> GetMovieReleaseDatesAsync(int movieId, CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetReleaseDatesAsync(movieId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResultContainer<Review>> GetMovieReviewsAsync(int movieId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.MoviesApi.GetReviewsAsync(movieId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> GetSimilarMoviesAsync(int movieId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.MoviesApi.GetSimilarMoviesAsync(movieId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TranslationContainer<MovieTranslationData>> GetMovieTranslationsAsync(int movieId,
        CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetTranslationsAsync(movieId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<WatchProviderContainer> GetMovieWatchProvidersAsync(int movieId,
        CancellationToken cancellationToken = default)
    {
        return await this.MoviesApi.GetWatchProvidersAsync(movieId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Response> AddMovieRatingAsync(int movieId, double value, string? sessionId, string? guestSessionId = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        AddRatingRequest addRatingRequest = new(value);

        return await this.MoviesApi.AddRatingAsync(movieId, addRatingRequest, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> AddMovieRatingAsync(int movieId, AddRatingRequest addRatingRequest, string? sessionId,
        string? guestSessionId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.MoviesApi.AddRatingAsync(movieId, addRatingRequest, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> DeleteMovieRatingAsync(int movieId, string? sessionId, string? guestSessionId = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.MoviesApi.DeleteRatingAsync(movieId, sessionId, guestSessionId, cancellationToken).ConfigureAwait(false);
    }
}
