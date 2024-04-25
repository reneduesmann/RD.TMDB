using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Domain.Models.Shared;

public interface IKnownFor
{
    MediaType MediaType { get; set; }
}
