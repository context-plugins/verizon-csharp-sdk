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
/// Check status and enable or disable service for Hyper Precise
/// </summary>
public sealed class DeviceServiceManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceServiceManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a hyper precise status
    /// </summary>
    /// <param name="imei">The International Mobile Equipment Identifier of the device.</param>
    /// <param name="accountNumber">The numeric name of the account and must include leading zeroes.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BullseyeServiceResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceHyperPreciseStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets the list of a status for hyper-precise location devices.
    /// </remarks>
    public Task<BullseyeServiceResult> GetDeviceHyperPreciseStatus(string imei,
        string accountNumber,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/devices/services"),
            [],
            [new Param("imei", imei), new Param("accountNumber", accountNumber)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BullseyeServiceResult>(),
            GetDeviceHyperPreciseStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Enable or disable hyper-precise
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BullseyeServiceResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateDeviceHyperPreciseStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable/disable hyper-precise service for a device.
    /// </remarks>
    public Task<BullseyeServiceResult> UpdateDeviceHyperPreciseStatus(BullseyeServiceRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/devices/services"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<BullseyeServiceResult>(),
            UpdateDeviceHyperPreciseStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
