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
/// Device logs on the server.
/// </summary>
public sealed class ServerLogging
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ServerLogging(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get check-in history for the device specified
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="deviceId">Device IMEI identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CheckInHistoryItem"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceCheckInHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.
    /// </remarks>
    public Task<IReadOnlyList<CheckInHistoryItem>> GetDeviceCheckInHistory(string account,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}/checkInHistory"),
            [new TemplateParam("account", account), new TemplateParam("deviceId", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CheckInHistoryItem>>(),
            GetDeviceCheckInHistoryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
