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
/// Create and manage groups to recieve notifications and alerts
/// </summary>
public sealed class SensorInsightsNotificationGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsNotificationGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add users to a notification group
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsAddUsersToNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task SensorInsightsAddUsersToNotificationGroupRequest(DtoAddUsersToNotificationGroupRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/notificationGroups/actions/add-users"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SensorInsightsAddUsersToNotificationGroupRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Create a notification group
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoNotificationGroupResponseEntity"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsCreateNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task<DtoNotificationGroupResponseEntity> SensorInsightsCreateNotificationGroupRequest(DtoCreateNotificationGroupRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/notificationGroups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DtoNotificationGroupResponseEntity>(),
            SensorInsightsCreateNotificationGroupRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a notification group
    /// </summary>
    /// <param name="payload">Payload for the delete request.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsDeleteNotificationGroupError"/> when the server returns an error response.</exception>
    public Task SensorInsightsDeleteNotificationGroup(DtoDeleteNotificationGroupRequest payload,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/notificationGroups"),
            [],
            [new Param("payload", payload)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SensorInsightsDeleteNotificationGroupErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a notification group
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoNotificationGroupResponseEntity"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsListNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DtoNotificationGroupResponseEntity>> SensorInsightsListNotificationGroupRequest(DtoListNotificationGroupRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/notificationGroups/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<DtoNotificationGroupResponseEntity>>(),
            SensorInsightsListNotificationGroupRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Remove users from a notification group
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsRemoveUsersFromNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task SensorInsightsRemoveUsersFromNotificationGroupRequest(DtoRemoveUsersFromNotificationGroupRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/notificationGroups/actions/remove-users"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SensorInsightsRemoveUsersFromNotificationGroupRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Partially update a notification group
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoNotificationGroupResponseEntity"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsUpdateNotificationGroupRequestError"/> when the server returns an error response.</exception>
    public Task<DtoNotificationGroupResponseEntity> SensorInsightsUpdateNotificationGroupRequest(DtoUpdateNotificationGroupRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/notificationGroups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<DtoNotificationGroupResponseEntity>(),
            SensorInsightsUpdateNotificationGroupRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
