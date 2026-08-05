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
using Verizon.Models.Enums;

namespace Verizon.Api;

/// <summary>
/// State of Firmware across devices in the account.
/// </summary>
public sealed class FirmwareV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FirmwareV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of available firmware
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="protocol">Filter to retrieve a specific protocol type used.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="FirmwarePackage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAvailableFirmware2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to list the firmware of an account.
    /// </remarks>
    public Task<IReadOnlyList<FirmwarePackage>> ListAvailableFirmware2(string acc,
        FirmwareProtocol protocol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/firmware/{acc}"),
            [new TemplateParam("acc", acc)],
            [new Param("protocol", protocol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<FirmwarePackage>>(),
            ListAvailableFirmware2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Report device firmware (asynchronous)
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="deviceId">Device identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceFirmwareVersionUpdateResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ReportDeviceFirmwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ask a device to report its firmware version asynchronously.
    /// </remarks>
    public Task<DeviceFirmwareVersionUpdateResult> ReportDeviceFirmware(string acc,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/firmware/{acc}/async/{deviceId}"),
            [new TemplateParam("acc", acc), new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceFirmwareVersionUpdateResult>(),
            ReportDeviceFirmwareErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// synchronize device firmware
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceFirmwareList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SynchronizeDeviceFirmwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Synchronize ThingSpace with the FOTA server for up to 100 devices.
    /// </remarks>
    public Task<DeviceFirmwareList> SynchronizeDeviceFirmware(string acc,
        FirmwareImei body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/firmware/{acc}/devices"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceFirmwareList>(),
            SynchronizeDeviceFirmwareErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
