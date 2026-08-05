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
/// Retrieve tallies of alerts from a recent daily period
/// </summary>
public sealed class SensorInsightsSmartAlertMetrics
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsSmartAlertMetrics(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Device Alerts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoQueryMetricsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorinsightsmetricsqueryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Device Alerts for the most recent daily period, up to 30 days.
    /// </remarks>
    public Task<DtoQueryMetricsResponse> Sensorinsightsmetricsquery(DtoQueryMetrics body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/smartAlerts/actions/metrics"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DtoQueryMetricsResponse>(),
            SensorinsightsmetricsqueryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
