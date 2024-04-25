using RD.Extensions.Enums.Contracts;
using RD.TMDB.Domain.Enums;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Models.Shared;

public class Video
{
    [JsonPropertyName("iso_639_1")]
    public Iso639_1 Language { get; set; }
    
    [JsonPropertyName("iso_3166_1")]
    public Iso3166_1 Country { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("key")]
    public string? Key { get; set; }
    
    [JsonPropertyName("site")]
    public VideoSite Site { get; set; }
    
    [JsonPropertyName("size")]
    public int Size { get; set; }
    
    [JsonPropertyName("type")]
    public VideoType Type { get; set; }
    
    [JsonPropertyName("official")]
    public bool Official { get; set; }
    
    [JsonPropertyName("published_at")]
    public DateTimeOffset PublishedAt { get; set; }
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public string GetVideoUrl(IEnumCache enumCache)
    {
        List<KeyValuePair<string, object>> valuePairs = enumCache.GetKeyValuePairs(this.Site);

        KeyValuePair<string, object> videoSite = valuePairs.FirstOrDefault(x => x.Key == VideoSiteKey);

        if(videoSite.Value is null)
        {
            return string.Empty;
        }

        return this.Site switch
        {
            VideoSite.Youtube => string.Format(videoSite.Value.ToString()!, this.Key),
            _ => string.Empty
        };
    }
}