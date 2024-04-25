using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvSeasons;
using RD.TMDB.Domain.Models.TvShows;
using RD.TMDB.Domain.Models.WatchProviders;
using static RD.TMDB.Domain.Configurations.ErrorMessage;
using ExternalId = RD.TMDB.Domain.Models.TvSeasons.ExternalId;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ITvSeasonProvider
{
    private ITvSeasonsApi? _tvSeasonsApi;

    private ITvSeasonsApi TvSeasonsApi => this._tvSeasonsApi ??= this.CreateRefitInterface<ITvSeasonsApi>();

    public async Task<TvSeasonDetail> GetTvSeasonDetailsAsync(int seriesId, int seasonNumber,
        TvSeasonInformation additionalTvSeasonInformations = TvSeasonInformation.Undefined, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        List<string> additionalInformations = this.GetAdditionalInformations(additionalTvSeasonInformations);

        string? languageToUse = this.GetLanguage(language);

        return await this.TvSeasonsApi.GetDetailsAsync(seriesId, seasonNumber, additionalInformations, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<TvSeasonAccountState>> GetTvSeasonAccountStatesAsync(int serisId, int seasonNumber,
        string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.TvSeasonsApi.GetAccountStatesAsync(serisId, seasonNumber, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<TvCast, TvCrew>> GetAggregateTvSeasonCreditsAsync(int seriesId, int seasonNumber, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvSeasonsApi.GetAggregateCreditsAsync(seriesId, seasonNumber, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ChangeContainer> GetTvSeasonChangesAsync(int seriesId, DateOnly? startDate = null, DateOnly? endDate = null,
        int? page = null, CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.TvSeasonsApi.GetChangesAsync(seriesId, startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<Cast, Crew>> GetTvSeasonCreditsAsync(int seriesId, int seasonNumber, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvSeasonsApi.GetCreditsAsync(seriesId, seasonNumber, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ExternalId> GetExternalTvSeasonIdsAsync(int seriesId, int seasonNumber, CancellationToken cancellationToken = default)
    {
        return await this.TvSeasonsApi.GetExternalIdsAsync(seriesId, seasonNumber, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Image> GetTvSeasonImagesAsync(int seriesId, int seasonNumber, IReadOnlyList<Iso639_1>? includeImageLanguages = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeImageLanguagesToUse = this.GetLanguages(includeImageLanguages);

        return await this.TvSeasonsApi.GetImagesAsync(seriesId, seasonNumber, includeImageLanguagesToUse,
            languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TranslationContainer<TvSeasonTranslationData>> GetTvSeasonTranslationsAsync(int seriesId, int seasonNumber,
        CancellationToken cancellationToken = default)
    {
        return await this.TvSeasonsApi.GetTranslationsAsync(seriesId, seasonNumber, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<Video>> GetTvSeasonVideosAsync(int seriesId, int seasonNumber, IReadOnlyList<Iso639_1>? includeVideoLanguage = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeVideoLanguagesToUse = this.GetLanguages(includeVideoLanguage);

        return await this.TvSeasonsApi.GetVideosAsync(seriesId, seasonNumber, includeVideoLanguagesToUse,
            languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<WatchProviderContainer> GetTvSeasonWatchProvidersAsync(int seriesId, int seasonNumber, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvSeasonsApi.GetWatchProvidersAsync(seriesId, seasonNumber, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }
}
