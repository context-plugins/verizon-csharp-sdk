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
/// Status of a campaign per device.
/// </summary>
public sealed class SoftwareManagementReportsV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementReportsV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a campaign device status.
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="campaignId">Campaign identifier.</param>
    /// <param name="lastSeenDeviceId">Last seen device identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2CampaignDevice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCampaignDeviceStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The report endpoint allows user to get the full list of device of a campaign.
    /// </remarks>
    public Task<V2CampaignDevice> GetCampaignDeviceStatus(string account,
        string campaignId,
        string? lastSeenDeviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/reports/{account}/campaigns/{campaignId}/devices"),
            [new TemplateParam("account", account), new TemplateParam("campaignId", campaignId)],
            [new Param("lastSeenDeviceId", lastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2CampaignDevice>(),
            GetCampaignDeviceStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get campaign history for specified status.
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="campaignStatus">Status of the campaign.</param>
    /// <param name="lastSeenCampaignId">Last seen campaign Id.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2CampaignHistory"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCampaignHistoryByStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The report endpoint allows user to get campaign history of an account for specified status.
    /// </remarks>
    public Task<V2CampaignHistory> GetCampaignHistoryByStatus(string account,
        string campaignStatus,
        string? lastSeenCampaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/reports/{account}/campaigns"),
            [new TemplateParam("account", account)],
            [new Param("campaignStatus", campaignStatus), new Param("lastSeenCampaignId", lastSeenCampaignId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2CampaignHistory>(),
            GetCampaignHistoryByStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get device software upgrade history
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="deviceId">Device IMEI identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceSoftwareUpgrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceFirmwareUpgradeHistory2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The endpoint allows user to get software upgrade history of a device based on device IMEI.
    /// </remarks>
    public Task<IReadOnlyList<DeviceSoftwareUpgrade>> GetDeviceFirmwareUpgradeHistory2(string account,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/reports/{account}/devices/{deviceId}"),
            [new TemplateParam("account", account), new TemplateParam("deviceId", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceSoftwareUpgrade>>(),
            GetDeviceFirmwareUpgradeHistory2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get account devices information
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="lastSeenDeviceId">Last seen device identifier.</param>
    /// <param name="distributionType">Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2AccountDeviceList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The device endpoint gets devices information of an account.
    /// </remarks>
    public Task<V2AccountDeviceList> ListAccountDevices2(string account,
        string? lastSeenDeviceId,
        string? distributionType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/devices/{account}"),
            [new TemplateParam("account", account)],
            [new Param("lastSeenDeviceId", lastSeenDeviceId), new Param("distributionType", distributionType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2AccountDeviceList>(),
            ListAccountDevices2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of available software
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="distributionType">Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SoftwarePackage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAvailableSoftwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to list a certain type of software of an account.
    /// </remarks>
    public Task<IReadOnlyList<SoftwarePackage>> ListAvailableSoftware(string account,
        string? distributionType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/software/{account}"),
            [new TemplateParam("account", account)],
            [new Param("distributionType", distributionType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SoftwarePackage>>(),
            ListAvailableSoftwareErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
