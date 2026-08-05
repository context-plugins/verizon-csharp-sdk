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
using Verizon.Models.Enums;

namespace Verizon.Api;

/// <summary>
/// Device information for an account.
/// </summary>
public sealed class AccountDevices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountDevices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve account device information such as reported firmware on the devices.
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="lastSeenDeviceId">Last seen device identifier.</param>
    /// <param name="protocol">Filter to retrieve a specific protocol type used.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3AccountDeviceList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountDeviceInformationError"/> when the server returns an error response.</exception>
    public Task<V3AccountDeviceList> GetAccountDeviceInformation(string acc,
        string? lastSeenDeviceId,
        DevicesProtocol? protocol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/devices/{acc}"),
            [new TemplateParam("acc", acc)],
            [new Param("lastSeenDeviceId", lastSeenDeviceId), new Param("protocol", protocol)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3AccountDeviceList>(),
            GetAccountDeviceInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get account device information for a list of devices
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceListResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountDevicesInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve device information for a list of devices on an account.
    /// </remarks>
    public Task<DeviceListResult> ListAccountDevicesInformation(string acc,
        DeviceImei body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/devices/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceListResult>(),
            ListAccountDevicesInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
