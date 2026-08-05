using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Errors;
using Verizon.Models;

namespace Verizon.Api;

/// <summary>
/// Start and end Connectivity Management sessions.
/// </summary>
public sealed class SessionManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SessionManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Ends a Connectivity Management session.
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LogOutRequest"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EndConnectivityManagementSessionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends a Connectivity Management session.
    /// </remarks>
    public Task<LogOutRequest> EndConnectivityManagementSession(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/session/logout"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<LogOutRequest>(),
            EndConnectivityManagementSessionErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns a new, randomly generated password for the current username
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionResetPasswordResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ResetConnectivityManagementPasswordError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.
    /// </remarks>
    public Task<SessionResetPasswordResult> ResetConnectivityManagementPassword(SessionResetPasswordRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/session/password/actions/reset"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<SessionResetPasswordResult>(),
            ResetConnectivityManagementPasswordErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Initiates a Connectivity Management session and returns a session token required in subsequent API requests.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LogInResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StartConnectivityManagementSessionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.
    /// </remarks>
    public Task<LogInResult> StartConnectivityManagementSession(LogInRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/session/login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LogInResult>(),
            StartConnectivityManagementSessionErrorResponse.Instance,
            [_auth.ThingspaceOauth],
            requestOptions,
            ct);
}
