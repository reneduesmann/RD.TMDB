using RD.TMDB.Domain.Models;
using RD.TMDB.Domain.Models.V4.Auth;

namespace RD.TMDB.Core.Contracts.V4;

public interface IAuthProvider
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="createRequestTokenRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method generates a new request token that you can ask a user to approve. 
    /// This is the first step in getting permission from a user to read and write data on their behalf.
    /// </remarks>
    /// <returns></returns>
    Task<RequestToken> CreateRequestTokenAsync(CreateRequestTokenRequest createRequestTokenRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="redirectTo"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method generates a new request token that you can ask a user to approve. 
    /// This is the first step in getting permission from a user to read and write data on their behalf.
    /// </remarks>
    /// <returns></returns>
    Task<RequestToken> CreateRequestTokenAsync(string redirectTo,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="createAccessTokenRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method will finish the user authentication flow and issue an official user access token. 
    /// The request token in this request is sent along as part of the POST body. 
    /// You should still use your standard API read access token for authenticating this request.
    /// </remarks>
    /// <returns></returns>
    Task<AccessToken> CreateAccessTokenAsync(CreateAccessTokenRequest createAccessTokenRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="requestToken"></param>
    /// <param name="cancellationToken"></param>
    /// <remarks>
    /// This method will finish the user authentication flow and issue an official user access token. 
    /// The request token in this request is sent along as part of the POST body. 
    /// You should still use your standard API read access token for authenticating this request.
    /// </remarks>
    /// <returns></returns>
    Task<AccessToken> CreateAccessTokenAsync(string requestToken,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Log out of a session.
    /// </summary>
    /// <param name="logoutRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Response> LogoutAsync(LogoutRequest logoutRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Log out of a session.
    /// </summary>
    /// <param name="accessToken"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Response> LogoutAsync(string accessToken, CancellationToken cancellationToken = default);
}