using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Models;

namespace Verizon.Api;

/// <summary>
/// Locate devices.
/// </summary>
public sealed class DevicesLocations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DevicesLocations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a queued location report
    /// </summary>
    /// <param name="accountName">Account identifier in "##########-#####".</param>
    /// <param name="txid">Transaction ID of the report to cancel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionId"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel a queued device location report.
    /// </remarks>
    public Task<TransactionId> CancelQueuedLocationReportGeneration(string accountName,
        string txid,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceLocation("/locationreports/{accountName}/report/{txid}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("txid", txid)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionId>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Create a location report
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AsynchronousLocationRequestResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Request an asynchronous device location report.
    /// </remarks>
    public Task<AsynchronousLocationRequestResult> CreateLocationReport(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceLocation("/locationreports"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<AsynchronousLocationRequestResult>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get the status of a location report
    /// </summary>
    /// <param name="accountName">Account identifier in "##########-#####".</param>
    /// <param name="txid">Transaction ID of the report.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LocationReportStatus"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the current status of a requested device location report.
    /// </remarks>
    public Task<LocationReportStatus> GetLocationReportStatus(string accountName,
        string txid,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceLocation("/locationreports/{accountName}/report/{txid}/status"),
            [new TemplateParam("accountName", accountName), new TemplateParam("txid", txid)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LocationReportStatus>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Obtain locations of IoT or consumer devices
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SynchronousLocationRequestResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.
    /// </remarks>
    public Task<SynchronousLocationRequestResult> ListDevicesLocationsAsynchronous(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceLocation("/devicelocations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SynchronousLocationRequestResult>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Obtain locations of devices
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Location"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This locations endpoint retrieves the locations for a list of devices.
    /// </remarks>
    public Task<IReadOnlyList<Location>> ListDevicesLocationsSynchronous(LocationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceLocation("/locations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<Location>>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a location report
    /// </summary>
    /// <param name="accountName">Account identifier in "##########-#####".</param>
    /// <param name="txid">Transaction ID from POST /locationreports response.</param>
    /// <param name="startindex">Zero-based number of the first record to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LocationReport"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Download a completed asynchronous device location report.
    /// </remarks>
    public Task<LocationReport> RetrieveLocationReport(string accountName,
        string txid,
        int startindex,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.DeviceLocation("/locationreports/{accountName}/report/{txid}/index/{startindex}"),
            [new TemplateParam("accountName", accountName),
                new TemplateParam("txid", txid),
                new TemplateParam("startindex", startindex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LocationReport>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
