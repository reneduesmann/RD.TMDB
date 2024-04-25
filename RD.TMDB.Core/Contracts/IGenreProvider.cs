using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Genres;

namespace RD.TMDB.Core.Contracts;

public interface IGenreProvider
{
    Task<GenreContainer> GetMovieGenresAsync(Iso639_1? language = null, CancellationToken cancellationToken = default);
    
    Task<GenreContainer> GetTvShowGenresAsync(Iso639_1? language = null, CancellationToken cancellationToken = default);
}