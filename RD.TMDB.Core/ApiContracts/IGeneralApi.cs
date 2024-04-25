namespace RD.TMDB.Core.ApiContracts;

public interface IGeneralApi
{
    [Get("/{size}/{filePath}")]
    Task<Stream> GetImageAsync(string size, string filePath, CancellationToken cancellationToken = default);
}
