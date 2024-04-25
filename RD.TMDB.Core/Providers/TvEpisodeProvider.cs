using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Images;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;
using RD.TMDB.Domain.Models.TvEpisodes;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ITvEpisodeProvider
{
    private ITvEpisodesApi? _tvEpisodesApi;

    private ITvEpisodesApi TvEpisodesApi => this._tvEpisodesApi ??= this.CreateRefitInterface<ITvEpisodesApi>();

    public async Task<TvEpisodeDetail> GetTvEpisodeDetailsAsync(int seriesId, int seasonNumber, int episodeNumber,
        TvEpisodeInformation additionalTvEpisodeInformations = TvEpisodeInformation.Undefined, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        List<string> additionalInformations = this.GetAdditionalInformations(additionalTvEpisodeInformations);

        string? languageToUse = this.GetLanguage(language);

        return await this.TvEpisodesApi.GetDetailsAsync(seriesId, seasonNumber, episodeNumber, additionalInformations,
            languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TvEpisodeAccountState> GetTvEpisodeAccountStatesAsync(int seriesId, int seasonNumber, int episodeNumber,
        string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.TvEpisodesApi.GetAccountStatesAsync(seriesId, seasonNumber, episodeNumber, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ChangeContainer> GetTvEpisodeChangesAsync(int episodeId, CancellationToken cancellationToken = default)
    {
        return await this.TvEpisodesApi.GetChangesAsync(episodeId, cancellationToken).ConfigureAwait(false);
    }

    public async Task<Credit> GetTvEpisodeCreditsAsync(int seriesId, int seasonNumber, int episodeNumber, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.TvEpisodesApi.GetCreditsAsync(seriesId, seasonNumber, episodeNumber, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ExternalId> GetExternalTvEpisodeIdsAsync(int seriesId, int seasonNumber, int episodeNumber, CancellationToken cancellationToken = default)
    {
        return await this.TvEpisodesApi.GetExternalIdsAsync(seriesId, seasonNumber, episodeNumber, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Image> GetTvEpisodeImagesAsync(int seriesId, int seasonNumber, int episodeNumber, IReadOnlyList<Iso639_1>? includeImageLanguages = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeImageLanguagesToUse = this.GetLanguages(includeImageLanguages);

        return await this.TvEpisodesApi.GetImagesAsync(seriesId, seasonNumber, episodeNumber,
            includeImageLanguagesToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TranslationContainer<TvEpisodeTranslationData>> GetTvEpisodeTranslationsAsync(int seriesId, int seasonNumber, int episodeNumber,
        CancellationToken cancellationToken = default)
    {
        return await this.TvEpisodesApi.GetTranslationsAsync(seriesId, seasonNumber, episodeNumber, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Result<Video>> GetTvEpisodeVideosAsync(int seriesId, int seasonNumber, int episodeNumber, IReadOnlyList<Iso639_1>? includeVideoLanguage = null,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        IEnumerable<string>? includeVideoLanguagesToUse = this.GetLanguages(includeVideoLanguage);

        return await this.TvEpisodesApi.GetVideosAsync(seriesId, seasonNumber, episodeNumber,
            includeVideoLanguagesToUse, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> AddTvEpisodeRatingAsync(int seriesId, int seasonNumber, int episodeNumber, double value,
        string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        AddRatingRequest request = new(value);

        return await this.TvEpisodesApi.AddRatingAsync(seriesId, seasonNumber, episodeNumber, request, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Response> DeleteTvEpisodeRatingAsync(int seriesId, int seasonNumber, int episodeNumber,
        string? sessionId, string? guestSessionId = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sessionId) && string.IsNullOrWhiteSpace(guestSessionId))
        {
            throw new ArgumentException(AtLeastOneSessionIdIsRequired);
        }

        return await this.TvEpisodesApi.DeleteRatingAsync(seriesId, seasonNumber, episodeNumber, sessionId, guestSessionId, cancellationToken)
            .ConfigureAwait(false);
    }
}
