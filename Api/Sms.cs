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
/// Exchange Short Message Service (SMS) messages with devices.
/// </summary>
public sealed class Sms
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Sms(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieves queued SMS messages sent by all M2M MC devices associated with an account.
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="next">Continue the previous query from the URL in Location Header.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SmsmessagesQueryResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDevicesSmsmessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.
    /// </remarks>
    public Task<SmsmessagesQueryResult> ListDevicesSmsmessages(string aname,
        long? next,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/sms/{aname}/history"),
            [new TemplateParam("aname", aname)],
            [new Param("next", next)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SmsmessagesQueryResult>(),
            ListDevicesSmsmessagesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Sends an SMS message to one or more devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SendSmstoDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.
    /// </remarks>
    public Task<DeviceManagementResult> SendSmstoDevice(SmssendRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/sms"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            SendSmstoDeviceErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Starts delivery of queued SMS messages for the specific account.
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectivityManagementSuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StartQueuedSmsdeliveryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.
    /// </remarks>
    public Task<ConnectivityManagementSuccessResult> StartQueuedSmsdelivery(string aname,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/sms/{aname}/startCallbacks"),
            [new TemplateParam("aname", aname)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<ConnectivityManagementSuccessResult>(),
            StartQueuedSmsdeliveryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
