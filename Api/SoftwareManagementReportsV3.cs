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
/// Status of a campaign per device.
/// </summary>
public sealed class SoftwareManagementReportsV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementReportsV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a campaign device status
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="campaignId">Campaign identifier.</param>
    /// <param name="lastSeenDeviceId">Last seen device identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3CampaignDevice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCampaignDeviceStatus2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of all devices in a campaign and the status of each device.
    /// </remarks>
    public Task<V3CampaignDevice> GetCampaignDeviceStatus2(string acc,
        string campaignId,
        string? lastSeenDeviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/reports/{acc}/campaigns/{campaignId}/devices"),
            [new TemplateParam("acc", acc), new TemplateParam("campaignId", campaignId)],
            [new Param("lastSeenDeviceId", lastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3CampaignDevice>(),
            GetCampaignDeviceStatus2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get firmware campaign status
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="campaignStatus">Campaign status.</param>
    /// <param name="lastSeenCampaignId">Last seen campaign Id.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3CampaignHistory"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCampaignHistoryByStatus2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of campaigns for an account that have a specified campaign status.
    /// </remarks>
    public Task<V3CampaignHistory> GetCampaignHistoryByStatus2(string acc,
        CampaignStatus campaignStatus,
        string? lastSeenCampaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/reports/{acc}/firmware/campaigns"),
            [new TemplateParam("acc", acc)],
            [new Param("campaignStatus", campaignStatus), new Param("lastSeenCampaignId", lastSeenCampaignId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3CampaignHistory>(),
            GetCampaignHistoryByStatus2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get device campaign history
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="deviceId">Device IMEI identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceFirmwareUpgrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceFirmwareUpgradeHistory3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve campaign history for a specific device.
    /// </remarks>
    public Task<IReadOnlyList<DeviceFirmwareUpgrade>> GetDeviceFirmwareUpgradeHistory3(string acc,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/reports/{acc}/devices/{deviceId}"),
            [new TemplateParam("acc", acc), new TemplateParam("deviceId", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceFirmwareUpgrade>>(),
            GetDeviceFirmwareUpgradeHistory3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
