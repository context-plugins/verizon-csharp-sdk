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
/// Sensor tasks and information
/// </summary>
public sealed class SensorInsightsSensors
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsSensors(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Query sensors on an account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ResourceDevice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsListSensorDevicesRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<ResourceDevice>> SensorInsightsListSensorDevicesRequest(DtoListSensorDevicesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/devices/sensors/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<ResourceDevice>>(),
            SensorInsightsListSensorDevicesRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// OffBoard a sensor
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsOffBoardSensorRequestError"/> when the server returns an error response.</exception>
    public Task SensorInsightsOffBoardSensorRequest(DtoOffBoardSensorRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/devices/sensors/offboard"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SensorInsightsOffBoardSensorRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// OnBoard a sensor
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsOnBoardSensorRequestError"/> when the server returns an error response.</exception>
    public Task SensorInsightsOnBoardSensorRequest(DtoOnBoardSensorRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/devices/sensors/onboard"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SensorInsightsOnBoardSensorRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get a sensor's offboarding status
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoSensorOffBoardingStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsSensorOffBoardingStatusRequestError"/> when the server returns an error response.</exception>
    public Task<DtoSensorOffBoardingStatusResponse> SensorInsightsSensorOffBoardingStatusRequest(DtoSensorOffBoardStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/devices/sensors/offboard/status/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DtoSensorOffBoardingStatusResponse>(),
            SensorInsightsSensorOffBoardingStatusRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get a sensor's onboarding status
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoSensorOnBoardingStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsSensorOnBoardStatusRequestError"/> when the server returns an error response.</exception>
    public Task<DtoSensorOnBoardingStatusResponse> SensorInsightsSensorOnBoardStatusRequest(DtoSensorOnBoardStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/devices/sensors/onboard/status/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DtoSensorOnBoardingStatusResponse>(),
            SensorInsightsSensorOnBoardStatusRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
