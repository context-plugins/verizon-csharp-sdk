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
/// Monitor the health of devices and the network
/// </summary>
public sealed class SensorInsightsHealthScore
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsHealthScore(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a network health score
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoGetNetworkHealthScoreResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsGetNetworkHealthScoreResponseError"/> when the server returns an error response.</exception>
    public Task<DtoGetNetworkHealthScoreResponse> SensorInsightsGetNetworkHealthScoreResponse(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/healthscore/network"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DtoGetNetworkHealthScoreResponse>(),
            SensorInsightsGetNetworkHealthScoreResponseErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get health score summary
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DtoHealthScoreSummary"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsHealthScoreSummaryError"/> when the server returns an error response.</exception>
    public Task<DtoHealthScoreSummary> SensorInsightsHealthScoreSummary(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/healthscore/summary"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DtoHealthScoreSummary>(),
            SensorInsightsHealthScoreSummaryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
