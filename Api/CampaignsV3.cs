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
/// Schedule, retrieve or cancel scheduled FOTA campaigns.
/// </summary>
public sealed class CampaignsV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CampaignsV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a previously scheduled firmware campaign. This api is allowed before the campaign StartDate
    /// </summary>
    /// <param name="accountName">Account identifier.</param>
    /// <param name="campaignId">Firmware upgrade information.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3SuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelCampaign2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.
    /// </remarks>
    public Task<FotaV3SuccessResult> CancelCampaign2(string accountName,
        string campaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/campaigns/{accountName}/{campaignId}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("campaignId", campaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV3SuccessResult>(),
            CancelCampaign2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve campaign level information
    /// </summary>
    /// <param name="accountName">Account identifier.</param>
    /// <param name="campaignId">Firmware upgrade identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Campaign"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCampaignInformation2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows the user to retrieve campaign level information for a specified campaign.
    /// </remarks>
    public Task<Campaign> GetCampaignInformation2(string accountName,
        string campaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/campaigns/{accountName}/{campaignId}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("campaignId", campaignId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Campaign>(),
            GetCampaignInformation2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Schedule a firmware upgrade
    /// </summary>
    /// <param name="accountName">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareCampaign"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScheduleCampaignFirmwareUpgrade2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows a user to schedule a firmware upgrade for a list of devices.
    /// </remarks>
    public Task<FirmwareCampaign> ScheduleCampaignFirmwareUpgrade2(string accountName,
        CampaignFirmwareUpgrade body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/campaigns/firmware/{accountName}"),
            [new TemplateParam("accountName", accountName)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<FirmwareCampaign>(),
            ScheduleCampaignFirmwareUpgrade2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Change firmware campaign dates and time windows. This api is allowed before the campaign StartDate
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="campaignId">Firmware upgrade information.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareCampaign"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCampaignDates2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
    /// </remarks>
    public Task<FirmwareCampaign> UpdateCampaignDates2(string acc,
        string campaignId,
        V3ChangeCampaignDatesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/campaigns/firmware/{acc}/{campaignId}/dates"),
            [new TemplateParam("acc", acc), new TemplateParam("campaignId", campaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<FirmwareCampaign>(),
            UpdateCampaignDates2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Add or Remove devices to an existing firmware campaign. This api is allowed before the campaign StartDate
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="campaignId">Unique identifier of a campaign.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3AddOrRemoveDeviceResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCampaignFirmwareDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to Add or Remove devices to an existing campaign.
    /// </remarks>
    public Task<V3AddOrRemoveDeviceResult> UpdateCampaignFirmwareDevices2(string acc,
        string campaignId,
        V3AddOrRemoveDeviceRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/campaigns/firmware/{acc}/{campaignId}"),
            [new TemplateParam("acc", acc), new TemplateParam("campaignId", campaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V3AddOrRemoveDeviceResult>(),
            UpdateCampaignFirmwareDevices2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
