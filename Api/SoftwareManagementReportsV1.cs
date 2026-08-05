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
/// Status and history information.
/// </summary>
public sealed class SoftwareManagementReportsV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementReportsV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns the upgrade history of the specified device from the previous six months.
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="deviceId">The IMEI of the device.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceUpgradeHistory"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceFirmwareUpgradeHistoryError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<DeviceUpgradeHistory>> GetDeviceFirmwareUpgradeHistory(string account,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/reports/{account}/devices/{deviceId}"),
            [new TemplateParam("account", account), new TemplateParam("deviceId", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceUpgradeHistory>>(),
            GetDeviceFirmwareUpgradeHistoryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get list of devices in the account
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="startIndex">Only return devices with IMEIs larger than this value. Use 0 for the first request. If <c>hasMoreData</c>=true in the response, use the <c>lastSeenDeviceId</c> value from the response as the startIndex in the next request.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceListQueryResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.
    /// </remarks>
    public Task<DeviceListQueryResult> ListAccountDevices(string account,
        string startIndex,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/devices/{account}/index/{startIndex}"),
            [new TemplateParam("account", account), new TemplateParam("startIndex", startIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceListQueryResult>(),
            ListAccountDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns a list of all upgrades with a specified status.
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="upgradeStatus">The status of the upgrades that you want to retrieve.</param>
    /// <param name="startIndex">The zero-based number of the first record to return. Set startIndex=0 for the first request. If <c>hasMoreFlag</c>=true in the response, use the <c>lastSeenUpgradeId</c> value from the response as the startIndex in the next request.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpgradeListQueryResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListUpgradesForSpecifiedStatusError"/> when the server returns an error response.</exception>
    public Task<UpgradeListQueryResult> ListUpgradesForSpecifiedStatus(string account,
        UpgradeStatus upgradeStatus,
        string startIndex,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/reports/{account}/status/{upgradeStatus}/index/{startIndex}"),
            [new TemplateParam("account", account),
                new TemplateParam("upgradeStatus", upgradeStatus),
                new TemplateParam("startIndex", startIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UpgradeListQueryResult>(),
            ListUpgradesForSpecifiedStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
