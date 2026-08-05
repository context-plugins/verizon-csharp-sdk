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
/// Check device usage
/// </summary>
public sealed class DeviceReports
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceReports(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// An aggregated asynchronous sessions and usage report for a user specified selection of devices and date range
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregatedReportCallbackResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CalculateAggregatedReportAsynchronousError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculate aggregated report per day with number of sessions and usage information. User will receive an asynchronous callback for the specified list of devices (Max 10000) and date range (Max 180 days).
    /// </remarks>
    public Task<AggregatedReportCallbackResult> CalculateAggregatedReportAsynchronous(AggregateSessionReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/report/async/aggregate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AggregatedReportCallbackResult>(),
            CalculateAggregatedReportAsynchronousErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// An aggregated sessions and usage report for a user specified selection of devices and date range
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregateSessionReport"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CalculateAggregatedReportSynchronousError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculate aggregated report per day with number of sessions and usage information. User will receive synchronous response for specified list of devices (Max 10) and date range (Max 180 days).
    /// </remarks>
    public Task<AggregateSessionReport> CalculateAggregatedReportSynchronous(AggregateSessionReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/report/aggregate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AggregateSessionReport>(),
            CalculateAggregatedReportSynchronousErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// A daily usage report for a single device for a specified date range (up to 180 days).
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionReport"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSessionsReportError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Detailed report of session duration and number of bytes transferred per day.
    /// </remarks>
    public Task<SessionReport> GetSessionsReport(SessionReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/report/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SessionReport>(),
            GetSessionsReportErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
