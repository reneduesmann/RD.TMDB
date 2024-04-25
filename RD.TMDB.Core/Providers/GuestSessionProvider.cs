using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Accounts;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IGuestSessionProvider
{
    private IGuestSessionsApi? _guestSessionsApi;

    private IGuestSessionsApi GuestSessionsApi => this._guestSessionsApi ??= this.CreateRefitInterface<IGuestSessionsApi>();

    public async Task<ResultContainer<RatedMovie>> GetGuestRatedMoviesAsync(string guestSessionId, Iso639_1? language = null,
        int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(guestSessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = this.GetEnumValue(sortBy);

        return await this.GuestSessionsApi.GetRatedMoviesAsync(guestSessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<RatedTvShow>> GetGuestRatedTvShowsAsync(string guestSessionId, Iso639_1? language = null,
               int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(guestSessionId);

        string? languageToUse = this.GetLanguage(language);
        string? sortByToUse = this.GetEnumValue(sortBy);

        return await this.GuestSessionsApi.GetRatedTvShowsAsync(guestSessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<RatedTvEpisode>> GetGuestRatedTvEpisodesAsync(string guestSessionId, Iso639_1? language = null,
               int? page = null, SortBy? sortBy = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(guestSessionId);

        string? languageToUse = this.GetLanguage(language);
        string ? sortByToUse = this.GetEnumValue(sortBy);

        return await this.GuestSessionsApi.GetRatedTvEpisodesAsync(guestSessionId, languageToUse, page, sortByToUse, cancellationToken)
            .ConfigureAwait(false);
    }
}
