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
/// Monitor device reachability and connection status.
/// </summary>
public sealed class DeviceMonitoring
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceMonitoring(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Register for notification reports based on the request type.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeviceReachabilityError"/> when the server returns an error response.</exception>
    public Task<RequestResponse> DeviceReachability(NotificationReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/diagnostics/basic/devicereachability"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            DeviceReachabilityErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Stop Device Reachability monitors.
    /// </summary>
    /// <param name="stopreachabilitypayload">Payload for the Stop Device Reachability monitors request.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StopDeviceReachabilityError"/> when the server returns an error response.</exception>
    public Task<RequestResponse> StopDeviceReachability(StopMonitorRequest stopreachabilitypayload,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/diagnostics/basic/devicereachability"),
            [],
            [new Param("stopreachabilitypayload", stopreachabilitypayload)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<RequestResponse>(),
            StopDeviceReachabilityErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
