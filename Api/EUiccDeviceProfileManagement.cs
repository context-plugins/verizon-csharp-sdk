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

public sealed class EUiccDeviceProfileManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EUiccDeviceProfileManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a local profile from eUICC devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLocalProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.
    /// </remarks>
    public Task<RequestResponse> DeleteLocalProfile(ProfileChangeStateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            DeleteLocalProfileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Disable a local profile on eUICC devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DisableLocalProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.
    /// </remarks>
    public Task<RequestResponse> DisableLocalProfile(ProfileChangeStateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/disable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            DisableLocalProfileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Download a local profile to eUICC devices and leave the profile disabled.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DownloadLocalProfileToDisableError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Downloads an eUICC local profile to devices and leaves the profile disabled.
    /// </remarks>
    public Task<DeviceManagementResult> DownloadLocalProfileToDisable(ProfileChangeStateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/download_disable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            DownloadLocalProfileToDisableErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Download a local profile to eUICC devices and enable the profile.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DownloadLocalProfileToEnableError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Downloads an eUICC local profile to devices and enables the profile.
    /// </remarks>
    public Task<DeviceManagementResult> DownloadLocalProfileToEnable(ProfileChangeStateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/download_enable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            DownloadLocalProfileToEnableErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Enable a local profile on eUICC devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableLocalProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable a local profile that has been downloaded to eUICC devices.
    /// </remarks>
    public Task<RequestResponse> EnableLocalProfile(ProfileChangeStateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/enable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            EnableLocalProfileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
