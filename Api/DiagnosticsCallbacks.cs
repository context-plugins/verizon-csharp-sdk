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

public sealed class DiagnosticsCallbacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DiagnosticsCallbacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get the registered callback information of diagnostics subscription
    /// </summary>
    /// <param name="accountName">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceDiagnosticsCallback"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDiagnosticsSubscriptionCallbackInfoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get the registered callback information of an existing diagnostics subscription.
    /// </remarks>
    public Task<IReadOnlyList<DeviceDiagnosticsCallback>> GetDiagnosticsSubscriptionCallbackInfo(string accountName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceDiagnostics("/callbacks"),
            [],
            [new Param("accountName", accountName)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceDiagnosticsCallback>>(),
            GetDiagnosticsSubscriptionCallbackInfoErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Register callbacks (custom headers)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceDiagnosticsCallback"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RegisterDiagnosticsCallbackUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.
    /// </remarks>
    public Task<DeviceDiagnosticsCallback> RegisterDiagnosticsCallbackUrl(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceDiagnostics("/callbacks"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceDiagnosticsCallback>(),
            RegisterDiagnosticsCallbackUrlErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a previously registered Callback
    /// </summary>
    /// <param name="accountName">Account identifier.</param>
    /// <param name="serviceName">Service name for callback notification.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceDiagnosticsCallback"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UnregisterDiagnosticsCallbackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a registered callback URL and credential.
    /// </remarks>
    public Task<DeviceDiagnosticsCallback> UnregisterDiagnosticsCallback(string accountName,
        string serviceName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceDiagnostics("/callbacks"),
            [],
            [new Param("accountName", accountName), new Param("serviceName", serviceName)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceDiagnosticsCallback>(),
            UnregisterDiagnosticsCallbackErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
