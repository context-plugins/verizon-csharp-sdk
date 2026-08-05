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
/// Device logs stored on the device itself.
/// </summary>
public sealed class ClientLogging
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ClientLogging(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Turn logging off for the device specified
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="deviceId">Device IMEI identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DisableDeviceLoggingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables logging for a specific device.
    /// </remarks>
    public Task DisableDeviceLogging(string account,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}"),
            [new TemplateParam("account", account), new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DisableDeviceLoggingErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Turn logging off for a list of devices.
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="deviceIds">The list of device IDs.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DisableLoggingForDevicesError"/> when the server returns an error response.</exception>
    public Task DisableLoggingForDevices(string account,
        string deviceIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices"),
            [new TemplateParam("account", account)],
            [new Param("deviceIds", deviceIds)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DisableLoggingForDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Turn logging on for the device specified
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="deviceId">Device IMEI identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLoggingStatus"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableDeviceLoggingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables logging for a specific device.
    /// </remarks>
    public Task<DeviceLoggingStatus> EnableDeviceLogging(string account,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}"),
            [new TemplateParam("account", account), new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLoggingStatus>(),
            EnableDeviceLoggingErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Turn logging on for the list of devices
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLoggingStatus"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableLoggingForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Each customer may have a maximum of 20 devices enabled for logging.
    /// </remarks>
    public Task<IReadOnlyList<DeviceLoggingStatus>> EnableLoggingForDevices(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLoggingStatus>>(),
            EnableLoggingForDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get logs for the device specified
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="deviceId">Device IMEI identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLog"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDeviceLogsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets logs for a specific device.
    /// </remarks>
    public Task<IReadOnlyList<DeviceLog>> ListDeviceLogs(string account,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices/{deviceId}/logs"),
            [new TemplateParam("account", account), new TemplateParam("deviceId", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLog>>(),
            ListDeviceLogsErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns an array of all devices in the specified account for which logging is enabled.
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceLoggingStatus"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDevicesWithLoggingEnabledError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DeviceLoggingStatus>> ListDevicesWithLoggingEnabled(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/logging/{account}/devices"),
            [new TemplateParam("account", account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceLoggingStatus>>(),
            ListDevicesWithLoggingEnabledErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
