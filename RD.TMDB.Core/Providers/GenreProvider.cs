using RD.TMDB.Core.ApiContracts;
using RD.TMDB.Core.Contracts;
using RD.TMDB.Domain.Enums;
using RD.TMDB.Domain.Models.Genres;

namespace RD.TMDB.Core.Providers;

public sealed partial class TmdbClient : IGenreProvider
{
    private IGenresApi? _genresApi;

    private IGenresApi GenresApi => this._genresApi ??= this.CreateRefitInterface<IGenresApi>();

    public async Task<GenreContainer> GetMovieGenresAsync(Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.GenresApi.GetMovieGenresAsync(languageToUse, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GenreContainer> GetTvShowGenresAsync(Iso639_1? language = null, CancellationToken cancellationToken = default)
    {
        string? languageToUse = this.GetLanguage(language);

        return await this.GenresApi.GetTvShowGenresAsync(languageToUse, cancellationToken).ConfigureAwait(false);
    }
}
