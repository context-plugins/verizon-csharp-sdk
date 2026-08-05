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
/// ThingSpace Intelligence is an offering of integrated connectivity and service management.
/// </summary>
public sealed class IntelligenceServiceController
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal IntelligenceServiceController(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve Windows
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AsynchronousRequestResultforplanner"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetConnectionPlannerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves available device windows for Connection Planner.
    /// </remarks>
    public Task<AsynchronousRequestResultforplanner> SetConnectionPlanner(GetDevicesWindowsRequestforplanner? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/v1/intelligence/device/connection-planner"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AsynchronousRequestResultforplanner>(),
            SetConnectionPlannerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Device Status for Connection Planner
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDeviceStatusesResponseforplanner"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StatusConnectionPlannerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the device status for the Connection Planner service.
    /// </remarks>
    public Task<GetDeviceStatusesResponseforplanner> StatusConnectionPlanner(GetDeviceStatusesRequestforplanner? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/v1/intelligence/device/connection-planner/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetDeviceStatusesResponseforplanner>(),
            StatusConnectionPlannerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
