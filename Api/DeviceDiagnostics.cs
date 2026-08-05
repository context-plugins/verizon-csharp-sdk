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
/// Helps to create &amp; manage diagnostics
/// </summary>
public sealed class DeviceDiagnostics
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceDiagnostics(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Requests for status of device based on the request type.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeviceReachabilityStatusUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If the devices do not already exist in the account, this API resource adds them before activation.
    /// </remarks>
    public Task<DeviceManagementResult> DeviceReachabilityStatusUsingPost(NotificationReportStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/diagnostics/basic/devicereachability/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            DeviceReachabilityStatusUsingPostErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve all the active monitors.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RetrieveActiveMonitorsUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve all the active monitors.
    /// </remarks>
    public Task<DeviceManagementResult> RetrieveActiveMonitorsUsingPost(RetrieveMonitorsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/diagnostics/basic/devicereachability/monitors"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            RetrieveActiveMonitorsUsingPostErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
