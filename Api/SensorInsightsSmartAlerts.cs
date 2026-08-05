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
/// Rules based alerts
/// </summary>
public sealed class SensorInsightsSmartAlerts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsSmartAlerts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Bulk update smart alerts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserSmartAlert"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsBulkUpdateError"/> when the server returns an error response.</exception>
    public Task<UserSmartAlert> SensorInsightsBulkUpdate(DtoBulkUpdate body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/smartAlerts/actions/bulkupdate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserSmartAlert>(),
            SensorInsightsBulkUpdateErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a smart alert
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="UserSmartAlert"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsListSmartAlertsRequestError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<UserSmartAlert>> SensorInsightsListSmartAlertsRequest(DtoListSmartAlertsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/smartAlerts/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<UserSmartAlert>>(),
            SensorInsightsListSmartAlertsRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Partially update a smart alert
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserSmartAlert"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SensorInsightsPatchSmartAlertRequestError"/> when the server returns an error response.</exception>
    public Task<UserSmartAlert> SensorInsightsPatchSmartAlertRequest(DtoPatchSmartAlertRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/smartAlerts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<UserSmartAlert>(),
            SensorInsightsPatchSmartAlertRequestErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
