using System;
using System.Collections.Generic;
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
/// Create user accounts and manage user roles and permissions
/// </summary>
public sealed class SensorInsightsUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsUsers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a user profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ResourceUser"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsCreateUserRequestError"/> when the server returns an error response.</exception>
    public Task<ResourceUser> SensorInsightsCreateUserRequest(DtoCreateUserRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/users"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ResourceUser>(),
            SensorInsightsCreateUserRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a user profile
    /// </summary>
    /// <param name="deleterequestpayload">Payload for the delete user request.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsDeleteUserError"/> when the server returns an error response.</exception>
    public Task SensorInsightsDeleteUser(DtoDeleteUserRequest deleterequestpayload,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/users"),
            [],
            [new Param("deleterequestpayload", deleterequestpayload)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SensorInsightsDeleteUserErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// A summary of user profile records on an account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ResourceUser"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsListUserRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<ResourceUser>> SensorInsightsListUserRequest(DtoListUserRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/users/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<ResourceUser>>(),
            SensorInsightsListUserRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Partially update a user profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ResourceUser"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsUpdateUserRequestError"/> when the server returns an error response.</exception>
    public Task<ResourceUser> SensorInsightsUpdateUserRequest(DtoUpdateUserRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/users"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<ResourceUser>(),
            SensorInsightsUpdateUserRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
