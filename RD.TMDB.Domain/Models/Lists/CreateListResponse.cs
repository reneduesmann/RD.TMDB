namespace RD.TMDB.Domain.Models.Lists;

public class CreateListResponse : Response
{
    [JsonPropertyName("list_id")]
    public int ListId { get; set; }
}
