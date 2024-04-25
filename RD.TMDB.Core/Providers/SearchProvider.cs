using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.Companies;
using RD.TMDB.Domain.Models.Keywords;
using RD.TMDB.Domain.Models.Requests;
using RD.TMDB.Domain.Models.Searches;
using RD.TMDB.Domain.Models.Shared;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ISearchProvider
{
    private ISearchApi? _searchApi;

    private ISearchApi SearchApi => this._searchApi ??= this.CreateRefitInterface<ISearchApi>();

    public async Task<ResultContainer<SearchCollection>> SearchCollectionsAsync(string query, bool? includeAdult = null,
        Iso639_1? language = null, int? page = null, Iso3166_1? region = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        string? languageToUse = this.GetLanguage(language);
        string? regionToUse = this.GetEnumValue(region);

        return await this.SearchApi.SearchCollectionsAsync(query, includeAdult, languageToUse, page, regionToUse, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Company>> SearchCompaniesAsync(string query, int? page = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        return await this.SearchApi.SearchCompaniesAsync(query, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Keyword>> SearchKeywordsAsync(string query, int? page = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        return await this.SearchApi.SearchKeywordsAsync(query, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Movie>> SearchMoviesAsync(string query, SearchMovieRequest? searchMovieRequest = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        SearchMovieQueryParameters? searchMovieQueryParameters = this.SearchMovieRequest(searchMovieRequest);

        return await this.SearchApi.SearchMoviesAsync(query, searchMovieQueryParameters, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<IKnownFor>> MultiSearchAsync(string query, bool? includeAdult = null,
        Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        string? languageToUse = this.GetLanguage(language);

        return await this.SearchApi.MultiSearchAsync(query, includeAdult, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<Person>> SearchPersonsAsync(string query, bool? includeAdult = null,
        Iso639_1? language = null, int? page = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        string? languageToUse = this.GetLanguage(language);

        return await this.SearchApi.SearchPersonsAsync(query, includeAdult, languageToUse, page, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<ResultContainer<TvShow>> SearchTvShowsAsync(string query, SearchTvShowRequest? searchTvShowRequest = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        SearchTvShowQueryParameters? searchTvShowQueryParameters = this.MapSearchTvShowRequest(searchTvShowRequest);

        return await this.SearchApi.SearchTvShowsAsync(query, searchTvShowQueryParameters, cancellationToken)
            .ConfigureAwait(false);
    }

    private SearchTvShowQueryParameters? MapSearchTvShowRequest(SearchTvShowRequest? searchTvShowRequest)
    {
        if (searchTvShowRequest is null)
        {
            return null;
        }

        return new()
        {
            FirstAirDateYear = searchTvShowRequest.FirstAirDateYear,
            IncludeAdult = searchTvShowRequest.IncludeAdult,
            Language = searchTvShowRequest.Language is null
                ? null
                : this._enumCache.GetStringValue(searchTvShowRequest.Language),
            Page = searchTvShowRequest.Page,
            Year = searchTvShowRequest.Year.HasValue ? searchTvShowRequest.Year.ToString() : null
        };
    }

    private SearchMovieQueryParameters? SearchMovieRequest(SearchMovieRequest? searchMovieRequest)
    {
        if (searchMovieRequest is null)
        {
            return null;
        }

        return new SearchMovieQueryParameters
        {
            IncludeAdult = searchMovieRequest.IncludeAdult,
            Language = searchMovieRequest.Language is null
                ? null
                : this._enumCache.GetStringValue(searchMovieRequest.Language),
            Page = searchMovieRequest.Page,
            PrimaryReleaseYear = searchMovieRequest.PrimaryReleaseYear.HasValue ? searchMovieRequest.PrimaryReleaseYear.ToString() : null,
            Region = searchMovieRequest.Region is null
                ? null
                : this._enumCache.GetStringValue(searchMovieRequest.Region),
            Year = searchMovieRequest.Year.HasValue ? searchMovieRequest.Year.ToString() : null
        };
    }
}
