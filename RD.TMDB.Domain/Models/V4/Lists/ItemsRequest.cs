namespace RD.TMDB.Domain.Models.V4.Lists;

public class ItemsRequest<TItems>
{
    [JsonPropertyName("items")]
    public List<TItems> Media { get; set; } = [];

    public ItemsRequest(List<TItems> media)
    {
        this.Media = media;
    }

    public ItemsRequest()
    {
        
    }
}
