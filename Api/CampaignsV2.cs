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
public sealed class CampaignsV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CampaignsV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a previously scheduled software upgrade
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="campaignId">Unique identifier of campaign.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2SuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelCampaignError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.
    /// </remarks>
    public Task<FotaV2SuccessResult> CancelCampaign(string account,
        string campaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/{account}/{campaignId}"),
            [new TemplateParam("account", account), new TemplateParam("campaignId", campaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2SuccessResult>(),
            CancelCampaignErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get information of a software upgrade.
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="campaignId">Software upgrade identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CampaignSoftware"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCampaignInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get information of a software upgrade.
    /// </remarks>
    public Task<CampaignSoftware> GetCampaignInformation(string account,
        string campaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/{account}/{campaignId}"),
            [new TemplateParam("account", account), new TemplateParam("campaignId", campaignId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CampaignSoftware>(),
            GetCampaignInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Schedule a software upgrade
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CampaignSoftware"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScheduleCampaignFirmwareUpgradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to schedule a software upgrade.
    /// </remarks>
    public Task<CampaignSoftware> ScheduleCampaignFirmwareUpgrade(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/{account}"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CampaignSoftware>(),
            ScheduleCampaignFirmwareUpgradeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Schedules a file upgrade.
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadAndScheduleFileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScheduleFileUpgradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You can upload configuration files and schedule them in a campaign to devices.
    /// </remarks>
    public Task<UploadAndScheduleFileResponse> ScheduleFileUpgrade(string acc,
        UploadAndScheduleFileRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/files/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UploadAndScheduleFileResponse>(),
            ScheduleFileUpgradeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Schedules a software upgrade for HTTP devices.
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadAndScheduleFileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScheduleSwupgradeHttpDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Campaign time windows for downloading and installing software are available as long as the device OEM supports this.
    /// </remarks>
    public Task<UploadAndScheduleFileResponse> ScheduleSwupgradeHttpDevices(string acc,
        SchedulesSoftwareUpgradeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/software/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UploadAndScheduleFileResponse>(),
            ScheduleSwupgradeHttpDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Change campaign dates and time windows
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="campaignId">Software upgrade information.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CampaignSoftware"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCampaignDatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
    /// </remarks>
    public Task<CampaignSoftware> UpdateCampaignDates(string account,
        string campaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/{account}/{campaignId}/dates"),
            [new TemplateParam("account", account), new TemplateParam("campaignId", campaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<CampaignSoftware>(),
            UpdateCampaignDatesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Add or Remove device to existing software upgrade
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="campaignId">Software upgrade information.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2AddOrRemoveDeviceResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCampaignFirmwareDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to Add or Remove devices to an existing software upgrade.
    /// </remarks>
    public Task<V2AddOrRemoveDeviceResult> UpdateCampaignFirmwareDevices(string account,
        string campaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/campaigns/{account}/{campaignId}"),
            [new TemplateParam("account", account), new TemplateParam("campaignId", campaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<V2AddOrRemoveDeviceResult>(),
            UpdateCampaignFirmwareDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
