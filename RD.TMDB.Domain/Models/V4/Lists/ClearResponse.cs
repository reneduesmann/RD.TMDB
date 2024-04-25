namespace RD.TMDB.Domain.Models.V4.Lists;

public class ClearResponse : Response
{
    [JsonPropertyName("items_deleted")]
    public int ItemsDeleted { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
