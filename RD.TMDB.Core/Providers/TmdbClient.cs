using RD.Extensions.Enums.Cache;
using RD.Extensions.Enums.Contracts;
using RD.Extensions.Enums.Enums;
using RD.TMDB.Core.Contracts.Factories;
using RD.TMDB.Core.Implementations.Factories;
using RD.TMDB.Core.JsonConverters;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Configurations;
using RD.TMDB.Domain.Models.Shared;
using System.Text.Json;
using System.Text.Json.Serialization;
using static RD.TMDB.Domain.Configurations.EnumConstant;
using static RD.TMDB.Domain.Configurations.ErrorMessage;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : ITmdbClient
{
    private const string _baseUrl = "https://api.themoviedb.org/";

    private const string _apiVersion = "3";

    private readonly IEnumCache _enumCache;

    private readonly IRefitApiFactory _refitApiFactory;

    private readonly HttpClient _httpClient;

    private readonly string _apiBaseUrl;

    private readonly RefitSettings _refitSettings;

    private ApiConfiguration? _apiConfiguration;

    /// <summary>
    /// Default language to use for requests when not in the request specified.
    /// </summary>
    public Iso639_1 DefaultLanguage { get; set; } = Iso639_1.English;

    /// <summary>
    /// Default country to use for requests when not in the request specified.
    /// </summary>
    public Iso3166_1 DefaultCountry { get; set; } = Iso3166_1.United_States;

    public TmdbClient(string bearerToken, IEnumCache enumCache, HttpClient httpClient,
        IRefitApiFactory? refitApiFactory = null, string baseUrl = _baseUrl, string apiVersion = _apiVersion)
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

        this._refitApiFactory = refitApiFactory ?? new RefitApiFactory(this._httpClient, this._refitSettings);
    }

    public TmdbClient(string bearerToken, HttpClient httpClient, string baseUrl = _baseUrl, string apiVersion = _apiVersion)
        : this(bearerToken, new EnumCache(new() { CachingMethod = CachingMethod.CacheEntireEnumWhenFirstUsed }),
              httpClient, null, baseUrl, apiVersion)
    {

    }

    public TmdbClient(string bearerToken, string baseUrl = _baseUrl, string apiVersion = _apiVersion)
        : this(bearerToken, new HttpClient(), baseUrl, apiVersion)
    {

    }

    public TmdbClient(string bearerToken, IRefitApiFactory refitApiFactory, string baseUrl = _baseUrl, string apiVersion = _apiVersion)
        : this(bearerToken, new EnumCache(new() { CachingMethod = CachingMethod.CacheEntireEnumWhenFirstUsed }),
              new(), refitApiFactory, baseUrl, apiVersion)
    {
        
    }

    /// <summary>
    /// Get the content of the image from the specified <paramref name="filePath"/>.
    /// </summary>
    /// <param name="size"></param>
    /// <param name="filePath"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<byte[]> GetImageAsync(string size, string filePath, CancellationToken cancellationToken = default)
    {
        if(this._apiConfiguration is null)
        {
            this._apiConfiguration = await this.GetApiConfigurationAsync(cancellationToken);
        }

        if (string.IsNullOrWhiteSpace(this._apiConfiguration.Images?.SecureBaseUrl))
        {
            throw new InvalidOperationException(ApiConfigurationMissingImageUrl);
        }

        string completeUrl = $"{this._apiConfiguration.Images.SecureBaseUrl}{size}{filePath}";

        return await this._httpClient.GetByteArrayAsync(completeUrl, cancellationToken);
    }

    /// <summary>
    /// Get the video url for the specified <paramref name="video"/>.
    /// </summary>
    /// <param name="video"></param>
    /// <returns></returns>
    public string GetVideoUrl(Video video)
    {
        if (video is null)
        {
            return string.Empty;
        }

        List<KeyValuePair<string, object>> valuePairs = this._enumCache.GetKeyValuePairs(video.Site);

        KeyValuePair<string, object> videoSite = valuePairs.FirstOrDefault(x => x.Key == VideoSiteKey);

        if (videoSite.Value is null)
        {
            return string.Empty;
        }

        return video.Site switch
        {
            VideoSite.Youtube => string.Format(videoSite.Value.ToString()!, video.Key),
            _ => string.Empty
        };
    }

    public void Dispose()
    {
        this._httpClient?.Dispose();
    }

    private TApi CreateRefitInterface<TApi>()
    {
        return this._refitApiFactory.CreateClient<TApi>();
    }

    private RefitSettings CreateRefitSettings()
    {
        return new()
        {
            ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions
            {
                Converters =
                {
                    new DateTimeOffsetConverter(),
                    new EnumConverter<Iso3166_1>(this._enumCache),
                    new EnumConverter<Iso639_1>(this._enumCache),
                    new EnumConverter<FileType>(this._enumCache),
                    new EnumConverter<BackdropSize>(this._enumCache),
                    new EnumConverter<PosterSize>(this._enumCache),
                    new EnumConverter<LogoSize>(this._enumCache),
                    new EnumConverter<ProfileSize>(this._enumCache),
                    new EnumConverter<StillSize>(this._enumCache),
                    new EnumConverter<ChangeKey>(this._enumCache),
                    new EnumConverter<CreditType>(this._enumCache),
                    new EnumConverter<MediaType>(this._enumCache),
                    new EnumConverter<ItemAction>(this._enumCache),
                    new EnumConverter<Department>(this._enumCache),
                    new EnumConverter<ListType>(this._enumCache),
                    new EnumConverter<VideoSite>(this._enumCache),
                    new EnumConverter<VideoType>(this._enumCache),
                    new CountryAndLanguageConverter(this._enumCache),
                    new CreditDetailConverter(),
                    new KnownForConverter(),
                    new AccountStateConverter(),
                    new TvSeasonAccountStateConverter(),
                    new TvEpisodeAccountStateConverter(),
                    new ChangeItemConverter(this._enumCache),
                    new ChangeConverter(),
                    new DateOnlyConverter(),
                    new GenreListConverter<TvShowGenre>(),
                    new TvShowDetailConverter()
                },
                UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
            })
        };
    }
}
