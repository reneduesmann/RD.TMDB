using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Images;

namespace RD.TMDB.Domain.Models.Companies;

public class CompanyImage : ImageBase
{
    [JsonPropertyName("file_type")]
    public FileType FileType { get; set; }
}
