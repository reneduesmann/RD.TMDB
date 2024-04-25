using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Discover;
using RD.TMDB.Domain.Models.Requests;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IDiscoverProvider
{
    private IDiscoverApi? _discoverApi;

    private IDiscoverApi DiscoverApi => this._discoverApi ??= this.CreateRefitInterface<IDiscoverApi>();

    public async Task<ResultContainer<Movie>> DiscoverMoviesAsync(DiscoverMovieRequest? discoverMovieRequest = null,
        CancellationToken cancellationToken = default)
    {
        DiscoverMovieQueryParameters? discoverMovieQueryParameters = this.MapDiscoverMovieRequest(discoverMovieRequest);

        return await this.DiscoverApi.DiscoverMoviesAsync(discoverMovieQueryParameters, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> DiscoverTvShowsAsync(DiscoverTvShowRequest? discoverTvShowRequest = null,
        CancellationToken cancellationToken = default)
    {
        DiscoverTvShowQueryParameters? discoverTvShowQueryParameters = this.MapDiscoverTvShowRequest(discoverTvShowRequest);

        return await this.DiscoverApi.DiscoverTvShowsAsync(discoverTvShowQueryParameters, cancellationToken).ConfigureAwait(false);
    }


    private DiscoverMovieQueryParameters? MapDiscoverMovieRequest(DiscoverMovieRequest? discoverMovieRequest)
    {
        if (discoverMovieRequest is null)
        {
            return null;
        }

        return new()
        {
            Certification = discoverMovieRequest.Certification,
            CertificationCountry = discoverMovieRequest.CertificationCountry is null
                ? null
                : this._enumCache.GetStringValue(discoverMovieRequest.CertificationCountry),
            CertificationGte = discoverMovieRequest.CertificationGte,
            CertificationLte = discoverMovieRequest.CertificationLte,
            IncludeAdult = discoverMovieRequest.IncludeAdult,
            IncludeVideo = discoverMovieRequest.IncludeVideo,
            Language = discoverMovieRequest.Language is null
                ? null
                : this._enumCache.GetStringValue(discoverMovieRequest.Language),
            Page = discoverMovieRequest.Page,
            PrimaryReleaseDateGte = discoverMovieRequest.PrimaryReleaseDateGte?.ToString("yyyy-MM-dd"),
            PrimaryReleaseDateLte = discoverMovieRequest.PrimaryReleaseDateLte?.ToString("yyyy-MM-dd"),
            PrimaryReleaseYear = discoverMovieRequest.PrimaryReleaseYear,
            Region = discoverMovieRequest.Region,
            ReleaseDateGte = discoverMovieRequest.ReleaseDateGte?.ToString("yyyy-MM-dd"),
            ReleaseDateLte = discoverMovieRequest.ReleaseDateLte?.ToString("yyyy-MM-dd"),
            SortBy = discoverMovieRequest.SortBy is null
                ? null
                : this._enumCache.GetStringValue(discoverMovieRequest.SortBy),
            VoteAverageGte = discoverMovieRequest.VoteAverageGte,
            VoteAverageLte = discoverMovieRequest.VoteAverageLte,
            VoteCountGte = discoverMovieRequest.VoteCountGte,
            VoteCountLte = discoverMovieRequest.VoteCountLte,
            WatchRegion = discoverMovieRequest.WatchRegion,
            WithCast = discoverMovieRequest.WithCast,
            WithCompanies = discoverMovieRequest.WithCompanies,
            WithCrew = discoverMovieRequest.WithCrew,
            WithGenres = discoverMovieRequest.WithGenres,
            WithKeywords = discoverMovieRequest.WithKeywords,
            WithOriginCountry = discoverMovieRequest.WithOriginCountry is null
                ? null
                : this._enumCache.GetStringValue(discoverMovieRequest.WithOriginCountry),
            WithOriginLanguage = discoverMovieRequest.WithOriginLanguage is null
                ? null
                : this._enumCache.GetStringValue(discoverMovieRequest.WithOriginLanguage),
            WithoutCompanies = discoverMovieRequest.WithoutCompanies,
            WithoutGenres = discoverMovieRequest.WithoutGenres,
            WithoutKeywords = discoverMovieRequest.WithoutKeywords,
            WithoutWatchProviders = discoverMovieRequest.WithoutWatchProviders,
            WithPeople = discoverMovieRequest.WithPeople,
            WithReleaseType = discoverMovieRequest.WithReleaseType,
            WithRuntimeGte = discoverMovieRequest.WithRuntimeGte,
            WithRuntimeLte = discoverMovieRequest.WithRuntimeLte,
            WithWatchMonetizationTypes = discoverMovieRequest.WithWatchMonetizationTypes,
            WithWatchProviders = discoverMovieRequest.WithWatchProviders,
            Year = discoverMovieRequest.Year
        };
    }

    private DiscoverTvShowQueryParameters? MapDiscoverTvShowRequest(DiscoverTvShowRequest? discoverTvShowRequest)
    {
        if (discoverTvShowRequest is null)
        {
            return null;
        }

        return new()
        {
            AirDateGte = discoverTvShowRequest.AirDateGte?.ToString("yyyy-MM-dd"),
            AirDateLte = discoverTvShowRequest.AirDateLte?.ToString("yyyy-MM-dd"),
            FirstAirDateGte = discoverTvShowRequest.FirstAirDateGte?.ToString("yyyy-MM-dd"),
            FirstAirDateLte = discoverTvShowRequest.FirstAirDateLte?.ToString("yyyy-MM-dd"),
            FirstAirDateYear = discoverTvShowRequest.FirstAirDateYear,
            IncludeAdult = discoverTvShowRequest.IncludeAdult,
            IncludeNullFirstAirDates = discoverTvShowRequest.IncludeNullFirstAirDates,
            Language = discoverTvShowRequest.Language is null
                ? null
                : this._enumCache.GetStringValue(discoverTvShowRequest.Language),
            Page = discoverTvShowRequest.Page,
            ScreenedTheatrically = discoverTvShowRequest.ScreenedTheatrically,
            SortBy = discoverTvShowRequest.SortBy is null
                ? null
                : this._enumCache.GetStringValue(discoverTvShowRequest.SortBy),
            Timezone = discoverTvShowRequest.Timezone,
            VoteAverageGte = discoverTvShowRequest.VoteAverageGte,
            VoteAverageLte = discoverTvShowRequest.VoteAverageLte,
            VoteCountGte = discoverTvShowRequest.VoteCountGte,
            VoteCountLte = discoverTvShowRequest.VoteCountLte,
            WatchRegion = discoverTvShowRequest.WatchRegion,
            WithCompanies = discoverTvShowRequest.WithCompanies,
            WithGenres = discoverTvShowRequest.WithGenres,
            WithKeywords = discoverTvShowRequest.WithKeywords,
            WithNetworks = discoverTvShowRequest.WithNetworks,
            WithOriginalLanguage = discoverTvShowRequest.WithOriginalLanguage is null
                ? null
                : this._enumCache.GetStringValue(discoverTvShowRequest.WithOriginalLanguage),
            WithOriginCountry = discoverTvShowRequest.WithOriginCountry is null
                ? null
                : this._enumCache.GetStringValue(discoverTvShowRequest.WithOriginCountry),
            WithoutCompanies = discoverTvShowRequest.WithoutCompanies,
            WithoutGenres = discoverTvShowRequest.WithoutGenres,
            WithoutKeywords = discoverTvShowRequest.WithoutKeywords,
            WithoutWatchProviders = discoverTvShowRequest.WithoutWatchProviders,
            WithRuntimeGte = discoverTvShowRequest.WithRuntimeGte,
            WithRuntimeLte = discoverTvShowRequest.WithRuntimeLte,
            WithStatus = discoverTvShowRequest.WithStatus,
            WithType = discoverTvShowRequest.WithType,
            WithWatchMonetizationTypes = discoverTvShowRequest.WithWatchMonetizationTypes,
            WithWatchProvíders = discoverTvShowRequest.WithWatchProvíders
        };
    }
}
