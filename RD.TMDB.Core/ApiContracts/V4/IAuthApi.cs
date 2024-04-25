using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.V4.Auth;

namespace RD.TMDB.Core.ApiContracts.V4;

public interface IAuthApi
{
    /// <summary>
    /// This method generates a new request token that you can ask a user to approve. 
    /// This is the first step in getting permission from a user to read and write data on their behalf.
    /// </summary>
    /// <param name="createRequestTokenRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// For detailed informations, see https://developer.themoviedb.org/v4/docs/authentication-user
    /// </remarks>
    /// <returns></returns>
    [Post("/auth/request_token")]
    Task<RequestToken> CreateRequestTokenAsync(
        [Body(BodySerializationMethod.Serialized)] CreateRequestTokenRequest createRequestTokenRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// This method will finish the user authentication flow and issue an official user access token. 
    /// The request token in this request is sent along as part of the POST body. 
    /// You should still use your standard API read access token for authenticating this request.
    /// </summary>
    /// <param name="createAccessTokenRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Post("/auth/access_token")]
    Task<AccessToken> CreateAccessTokenAsync(
        [Body(BodySerializationMethod.Serialized)] CreateAccessTokenRequest createAccessTokenRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Log out of a session.
    /// </summary>
    /// <param name="logoutRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [Delete("/auth/access_token")]
    Task<Response> LogoutAsync(
        [Body(BodySerializationMethod.Serialized)] LogoutRequest logoutRequest,
        CancellationToken cancellationToken = default);
}
