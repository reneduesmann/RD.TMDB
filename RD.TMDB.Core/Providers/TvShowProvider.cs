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
using RD.TMDB.Domain.Models.Reviews;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvShows;
using RD.TMDB.Domain.Models.WatchProviders;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ITvShowProvider
{
    private ITvShowsApi? _tvShowsApi;

    private ITvShowsApi TvShowsApi => this._tvShowsApi ??= this.CreateRefitInterface<ITvShowsApi>();

    public async Task<ResultContainer<TvShow>> GetAiringTvShowsTodayAsync(Iso639_1? language = null, int? page = null,
        string? timezone = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetAiringTodayAsync(languageToUse, page, timezone, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetOnTheAirTvShowsAsync(Iso639_1? language = null, int? page = null,
        string? timezone = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetOnTheAirAsync(languageToUse, page, timezone, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetPopularTvShowsAsync(Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetPopularAsync(languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetTopRatedTvShowsAsync(Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetTopRatedAsync(languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TvShowDetail> GetTvShowDetailsAsync(int seriesId,
        TvShowInformation additionalTvShowInformations = TvShowInformation.Undefined, Iso639_1? language = null,
        IReadOnlyList<int>? additionalTvSeasonInformations = null, CancellationToken cancellationToken = default)
    {
        List<string> additionalInformations = this.GetAdditionalInformations(additionalTvShowInformations);

        if(additionalTvSeasonInformations is not null && additionalTvSeasonInformations.Count > 0)
        {
            IEnumerable<string> seasons = additionalTvSeasonInformations.Select(season => $"season/{season}");
            additionalInformations.AddRange(seasons);
        }

        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetDetailsAsync(seriesId, additionalInformations, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<AccountState> GetTvShowAccountStatesAsync(int serieSId, string? sessionId, string? guestSessionId = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.TvShowsApi.GetAccountStatesAsync(serieSId, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<TvCast, TvCrew>> GetAggregateTvShowCreditsAsync(int seriesId, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetAggregateCreditsAsync(seriesId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<AlternativeTitle>> GetAlternativeTvShowTitlesAsync(int serisId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetAlternativeTitlesAsync(serisId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ChangeContainer> GetTvShowChangesAsync(int seriesId, DateOnly? startDate = null, DateOnly? endDate = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.TvShowsApi.GetChangesAsync(seriesId, startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<ContentRating>> GetContentTvShowRatingsAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetContentRatingsAsync(seriesId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Credit<Cast, Crew>> GetTvShowCreditsAsync(int seriesId, Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetCreditsAsync(seriesId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<TvEpisodeGroup>> GetTvShowEpisodeGroupsAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetEpisodeGroupsAsync(seriesId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ExternalId> GetExternalTvShowIdsAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetExternalIdsAsync(seriesId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Image> GetTvShowImagesAsync(int seriesId, IReadOnlyList<Iso639_1>? includeImageLanguages = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeImageLanguagesToUse = this.GetLanguages(includeImageLanguages);

        return await this.TvShowsApi.GetImagesAsync(seriesId, includeImageLanguagesToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<Keyword>> GetTvShowKeywordsAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetKeywordsAsync(seriesId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<TvShowDetail> GetLatestTvShowAsync(CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetLatestAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResultContainer<List>> GetTvShowListsAsync(int seriesId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetListsAsync(seriesId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetTvShowRecommendationsAsync(int seriesId, Iso639_1? language = null, int? page = null,
               CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetRecommendationsAsync(seriesId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Review>> GetTvShowReviewsAsync(int seriesId, Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetReviewsAsync(seriesId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<ScreenedTheatrically>> GetScreenedTheatricallyTvShowsAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetScreenedTheatricallyAsync(seriesId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> GetSimilarTvShowsAsync(int seriesId, Iso639_1? language = null, int? page = null,
               CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvShowsApi.GetSimilarAsync(seriesId, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TranslationContainer<TvShowTranslationData>> GetTvShowTranslationsAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetTranslationsAsync(seriesId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Result<Video>> GetTvShowVideosAsync(int seriesId, IReadOnlyList<Iso639_1>? includeVideoLanguage = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeVideoLanguagesToUse = this.GetLanguages(includeVideoLanguage);

        return await this.TvShowsApi.GetVideosAsync(seriesId, includeVideoLanguagesToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<WatchProviderContainer> GetTvShowWatchProvidersAsync(int seriesId, CancellationToken cancellationToken = default)
    {
        return await this.TvShowsApi.GetWatchProvidersAsync(seriesId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> AddTvShowRatingAsync(int seriesId, double value, string? sessionId, string? guestSession = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSession))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        AddRatingRequest request = new(value);

        return await this.TvShowsApi.AddRatingAsync(seriesId, request, sessionId, guestSession, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> DeleteTvShowRatingAsync(int seriesId, string? sessionId, string? guestSession = null,
               CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSession))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.TvShowsApi.DeleteRatingAsync(seriesId, sessionId, guestSession, cancellationToken)
            .ConfigureAwait(false);
    }
}
