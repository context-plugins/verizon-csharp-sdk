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

public sealed class DeviceProfileManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceProfileManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Activate a device for a profile.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActivateDeviceThroughProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to bring the device under management.
    /// </remarks>
    public Task<RequestResponse> ActivateDeviceThroughProfile(ActivateDeviceProfileRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/activate_enable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            ActivateDeviceThroughProfileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Activate a device.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ProfileToActivateDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to activate the device.
    /// </remarks>
    public Task<RequestResponse> ProfileToActivateDevice(ProfileRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            ProfileToActivateDeviceErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Deactivate a device.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ProfileToDeactivateDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to deactivate the device.
    /// </remarks>
    public Task<RequestResponse> ProfileToDeactivateDevice(DeactivateDeviceProfileRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/deactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            ProfileToDeactivateDeviceErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Set the fallback attribute.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ProfileToSetFallbackAttributeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows the profile to set the fallback attribute to the device.
    /// </remarks>
    public Task<RequestResponse> ProfileToSetFallbackAttribute(SetFallbackAttributeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/setfallbackattribute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            ProfileToSetFallbackAttributeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
