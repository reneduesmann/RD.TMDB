using RD.Extensions.Enums.Cache;
using RD.Extensions.Enums.Contracts;
using RD.Extensions.Enums.Enums;
using RD.TMDB.Core.JsonConverters;
using RD.TMDB.Domain.Enums;
using System.Text.Json.Serialization;

namespace RD.TMDB.Core.Providers.V4;

public sealed partial class TmdbV4Client : ITmdbV4Client
{
    private const string _baseUrl = "https://api.themoviedb.org/";

    private const string _apiVersion = "4";

    private readonly IEnumCache _enumCache;

    private readonly HttpClient _httpClient;

    private readonly string _apiBaseUrl;

    private readonly RefitSettings _refitSettings;

    /// <summary>
    /// Default language to use for requests when not in the request specified.
    /// </summary>
    public Iso639_1 DefaultLanguage { get; set; } = Iso639_1.English;

    public TmdbV4Client(string bearerToken, IEnumCache enumCache, HttpClient httpClient,
        string baseUrl = _baseUrl, string apiVersion = _apiVersion)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(bearerToken);
        ArgumentException.ThrowIfNullOrWhiteSpace(baseUrl);
        ArgumentException.ThrowIfNullOrWhiteSpace(apiVersion);

        this._enumCache = enumCache ?? throw new ArgumentNullException(nameof(enumCache));
        this._httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        this._apiBaseUrl = $"{baseUrl}{apiVersion}/";
        this._refitSettings = this.CreateRefitSettings();

        this._httpClient.BaseAddress = new(_apiBaseUrl);
        this._httpClient.DefaultRequestHeaders.Authorization = new("Bearer", bearerToken);
    }

    public TmdbV4Client(string bearerToken, HttpClient httpClient, string baseUrl = _baseUrl, string apiVersion = _apiVersion)
        : this(bearerToken, new EnumCache(new() { CachingMethod = CachingMethod.CacheEntireEnumWhenFirstUsed }), 
              httpClient, baseUrl, apiVersion)
    {

    }

    public TmdbV4Client(string bearerToken, string baseUrl = _baseUrl, string apiVersion = _apiVersion)
        : this(bearerToken, new(), baseUrl, apiVersion)
    {

    }

    public void Dispose()
    {
        this._httpClient?.Dispose();
    }

    private TApi CreateRefitInterface<TApi>()
    {
        return RestService.For<TApi>(this._httpClient, this._refitSettings);
    }

    private RefitSettings CreateRefitSettings()
    {
        return new()
        {
            ContentSerializer = new SystemTextJsonContentSerializer(new System.Text.Json.JsonSerializerOptions
            {
                Converters =
                {
                    new DateTimeOffsetConverter(),
                    new EnumConverter<Iso3166_1>(this._enumCache),
                    new EnumConverter<Iso639_1>(this._enumCache),
                    new EnumConverter<MediaType>(this._enumCache),
                    new KnownForConverter()
                },
                    UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
                })
            };
    }
}
