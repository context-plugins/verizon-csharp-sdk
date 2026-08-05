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

public sealed class SimSecureForIoTLicenses
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SimSecureForIoTLicenses(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Assigns licenses to one or more devices.
    /// </summary>
    /// <param name="xRequestId">Transaction Id.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SecuritySuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AssignLicenseToDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Assigns SIM-Secure for IoT licenses to SIMs.
    /// </remarks>
    public Task<SecuritySuccessResult> AssignLicenseToDevices(string? xRequestId,
        AssignLicenseRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.M2M("/v1/devices/license/actions/assign"),
            [],
            [],
            [new HeaderParam("X-Request-ID", xRequestId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SecuritySuccessResult>(),
            AssignLicenseToDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// UnAssigns licenses to one or more devices.
    /// </summary>
    /// <param name="xRequestId">Transaction Id.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SecuritySuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UnassignLicenseToDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unassigns SIM-Secure for IoT Flexible and Flexible Bundle license from SIMs.
    /// </remarks>
    public Task<SecuritySuccessResult> UnassignLicenseToDevices(string xRequestId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.M2M("/v1/devices/license/actions/assign"),
            [],
            [],
            [new HeaderParam("X-Request-ID", xRequestId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SecuritySuccessResult>(),
            UnassignLicenseToDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
