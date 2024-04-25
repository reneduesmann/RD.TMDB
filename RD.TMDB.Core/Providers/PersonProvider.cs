using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Changes;
using RD.TMDB.Domain.Models.Credits;
using RD.TMDB.Domain.Models.Persons;
using RD.TMDB.Domain.Models.Shared;
using RD.TMDB.Domain.Models.Translations;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IPersonProvider
{
    private IPersonsApi? _personsApi;

    private IPersonsApi PersonsApi => this._personsApi ??= this.CreateRefitInterface<IPersonsApi>();

    public async Task<ResultContainer<Person>> GetPopularPersonsAsync(Iso639_1? language = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.PersonsApi.GetPopularAsync(languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<PersonDetail> GetPersonDetailsAsync(int personId, PersonInformation additionalPersonInformation = PersonInformation.Undefined,
        Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        List<string> additionalInformations = this.GetAdditionalInformations(additionalPersonInformation);

        return await this.PersonsApi.GetDetailsAsync(personId, additionalInformations, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ChangeContainer> GetPersonChangesAsync(int personId, DateOnly? startDate = null, DateOnly? endDate = null, int? page = null,
        CancellationToken cancellationToken = default)
    {
        (string? startDateToUse, string? endDateToUse) = GetDates(startDate, endDate);

        return await this.PersonsApi.GetChangesAsync(personId, startDateToUse, endDateToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<CombinedCast, CombinedCrew>> GetCombinedPersonCreditsAsync(int personId, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.PersonsApi.GetCombinedCreditsAsync(personId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ExternalId> GetExternalPersonIdsAsync(int personId, CancellationToken cancellationToken = default)
    {
        return await this.PersonsApi.GetExternalIdsAsync(personId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<PersonImage> GetPersonImagesAsync(int personId, CancellationToken cancellationToken = default)
    {
        return await this.PersonsApi.GetImagesAsync(personId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<PersonDetail> GetLatestPersonAsync(CancellationToken cancellationToken = default)
    {
        return await this.PersonsApi.GetLatestAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<MovieCast, MovieCrew>> GetPersonMovieCreditsAsync(int personId, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.PersonsApi.GetMovieCreditsAsync(personId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Credit<TvShowCast, TvShowCrew>> GetPersonTvShowCreditsAsync(int personId, Iso639_1? language = null,
        CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.PersonsApi.GetTvShowCreditsAsync(personId, languageToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<TranslationContainer<PersonTranslationData>> GetPersonTranslationsAsync(int personId,
        CancellationToken cancellationToken = default)
    {
        return await this.PersonsApi.GetTranslationsAsync(personId, cancellationToken)
            .ConfigureAwait(false);
    }
}
