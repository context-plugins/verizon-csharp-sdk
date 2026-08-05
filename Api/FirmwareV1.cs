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
/// Schedule and monitor firmware upgrades.
/// </summary>
public sealed class FirmwareV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FirmwareV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a scheduled firmware upgrade.
    /// </summary>
    /// <param name="accountName">Account identifier in "##########-#####".</param>
    /// <param name="upgradeId">The UUID of the scheduled upgrade that you want to cancel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV1SuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelScheduledFirmwareUpgradeError"/> when the server returns an error response.</exception>
    public Task<FotaV1SuccessResult> CancelScheduledFirmwareUpgrade(string accountName,
        string upgradeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/upgrades/{accountName}/upgrade/{upgradeId}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("upgradeId", upgradeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV1SuccessResult>(),
            CancelScheduledFirmwareUpgradeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get list of available firmware
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Firmware"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAvailableFirmwareError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all device firmware images available for an account, based on the devices registered to that account.
    /// </remarks>
    public Task<IReadOnlyList<Firmware>> ListAvailableFirmware(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/firmware/{account}"),
            [new TemplateParam("account", account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Firmware>>(),
            ListAvailableFirmwareErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get information about a firmware upgrade
    /// </summary>
    /// <param name="accountName">Account identifier in "##########-#####".</param>
    /// <param name="upgradeId">The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareUpgrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListFirmwareUpgradeDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.
    /// </remarks>
    public Task<FirmwareUpgrade> ListFirmwareUpgradeDetails(string accountName,
        string upgradeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/upgrades/{accountName}/upgrade/{upgradeId}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("upgradeId", upgradeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FirmwareUpgrade>(),
            ListFirmwareUpgradeDetailsErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Schedule a firmware upgrade
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareUpgrade"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScheduleFirmwareUpgradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a firmware upgrade for devices.
    /// </remarks>
    public Task<FirmwareUpgrade> ScheduleFirmwareUpgrade(FirmwareUpgradeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/upgrades"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<FirmwareUpgrade>(),
            ScheduleFirmwareUpgradeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Change the device list for a scheduled upgrade
    /// </summary>
    /// <param name="accountName">Account identifier in "##########-#####".</param>
    /// <param name="upgradeId">The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FirmwareUpgradeChangeResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateFirmwareUpgradeDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add or remove devices from a scheduled upgrade.
    /// </remarks>
    public Task<FirmwareUpgradeChangeResult> UpdateFirmwareUpgradeDevices(string accountName,
        string upgradeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/upgrades/{accountName}/upgrade/{upgradeId}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("upgradeId", upgradeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<FirmwareUpgradeChangeResult>(),
            UpdateFirmwareUpgradeDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
