using RD.TMDB.Domain.Enums;

namespace RD.TMDB.Core;

public interface ITmdbV4Client : IDisposable
{
    /// <summary>
    /// Default language to use for requests when not in the request specified.
    /// </summary>
    Iso639_1 DefaultLanguage { get; set; }
}
