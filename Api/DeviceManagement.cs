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
/// Manage device connectivity and get device history.
/// </summary>
public sealed class DeviceManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Activates service for one or more devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActivateServiceForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If the devices do not already exist in the account, this API resource adds them before activation.
    /// </remarks>
    public Task<DeviceManagementResult> ActivateServiceForDevices(CarrierActivateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            ActivateServiceForDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Adds up to 200 new devices, without provisioning lines of service for them.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="AddDevicesResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this API if you want to manage some device settings before you are ready to activate service for the devices.
    /// </remarks>
    public Task<IReadOnlyList<AddDevicesResult>> AddDevices(AddDevicesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/add"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<AddDevicesResult>>(),
            AddDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Gets billed usage for for either multiple devices or an entire billing account.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BilledUsageInfoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets billed usage for for either multiple devices or an entire billing account.
    /// </remarks>
    public Task<DeviceManagementResult> BilledUsageInfo(BilledusageListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/usage/actions/billedusage/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            BilledUsageInfoErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Sets a new service plan for one or more devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ChangeDevicesServicePlanError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the service plan for one or more devices.
    /// </remarks>
    public Task<DeviceManagementResult> ChangeDevicesServicePlan(ServicePlanUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/plan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            ChangeDevicesServicePlanErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Checks whether devices are available to be activated.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckDevicesAvailabilityForActivationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks whether specified devices are registered by the manufacturer with the Verizon network and are available to be activated.
    /// </remarks>
    public Task<DeviceManagementResult> CheckDevicesAvailabilityForActivation(DeviceActivationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/availability/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            CheckDevicesAvailabilityForActivationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Deactivates service for one or more devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeactivateServiceForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deactivating service for a device may result in an early termination fee (ETF) being charged to the account, depending on the terms of the contract with Verizon. If your contract allows ETF waivers and if you want to use one for a particular deactivation, set the etfWaiver value to True.
    /// </remarks>
    public Task<DeviceManagementResult> DeactivateServiceForDevices(CarrierDeactivateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/deactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            DeactivateServiceForDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Deletes up to 200 deactive devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeleteDevicesResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteDeactivatedDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this API to remove unneeded devices from an account.
    /// </remarks>
    public Task<IReadOnlyList<DeleteDevicesResult>> DeleteDeactivatedDevices(DeleteDevicesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<DeleteDevicesResult>>(),
            DeleteDeactivatedDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// API for Uploading Devices to DMD.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeviceUploadError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Upload a device record
    /// </remarks>
    public Task<RequestResponse> DeviceUpload(DeviceUploadRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/upload"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RequestResponse>(),
            DeviceUploadErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Check the status of real-time orders.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeviceUploadStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks the status of an activation order and lists where the order is in the provisioning process.
    /// </remarks>
    public Task<DeviceManagementResult> DeviceUploadStatus(CheckOrderStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/requests/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            DeviceUploadStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns basic diagnostic information about a specified device, including connectivity, provisioning, and billing status.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceExtendedDiagnosticsResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceExtendedDiagnosticInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns extended diagnostic information about a specified device, including connectivity, provisioning, billing and location status.
    /// </remarks>
    public Task<DeviceExtendedDiagnosticsResult> GetDeviceExtendedDiagnosticInformation(DeviceExtendedDiagnosticsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/extendeddiagnostics/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceExtendedDiagnosticsResult>(),
            GetDeviceExtendedDiagnosticInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Request service suspension information about devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDeviceServiceSuspensionStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns DeviceSuspensionStatus callback messages containing the current device state and information on how many days a device has been suspended and can continue to be suspended.
    /// </remarks>
    public Task<DeviceManagementResult> GetDeviceServiceSuspensionStatus(DeviceSuspensionStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/suspension/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            GetDeviceServiceSuspensionStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Requests the current PRL version for devices, which can help determine which devices need a PRL update.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListCurrentDevicesPrlVersionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// 4G and GSM devices do not have a PRL.
    /// </remarks>
    public Task<DeviceManagementResult> ListCurrentDevicesPrlVersion(DevicePrlListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/prl/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            ListCurrentDevicesPrlVersionErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns information about a specified device or a list of devices in an account.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountDeviceListResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDevicesInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a single device or information about all devices that match the given parameters. Returned information includes device provisioning state, service plan, MDN, MIN, and IP address.
    /// </remarks>
    public Task<AccountDeviceListResult> ListDevicesInformation(AccountDeviceListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccountDeviceListResult>(),
            ListDevicesInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns the provisioning history of a device during a specified time period.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceProvisioningHistoryListResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDevicesProvisioningHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the provisioning history of a specified device during a specified time period.
    /// </remarks>
    public Task<IReadOnlyList<DeviceProvisioningHistoryListResult>> ListDevicesProvisioningHistory(DeviceProvisioningHistoryListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/history/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<DeviceProvisioningHistoryListResult>>(),
            ListDevicesProvisioningHistoryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Obtain the usage history of a specific device.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceUsageListResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDevicesUsageHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the network data usage history of a device during a specified time period.
    /// </remarks>
    public Task<DeviceUsageListResult> ListDevicesUsageHistory(DeviceUsageListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/usage/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceUsageListResult>(),
            ListDevicesUsageHistoryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns a list of all 4G devices with an ICCID that was not activated with the expected IMEI.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceMismatchListResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListDevicesWithImeiIccidMismatchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.
    /// </remarks>
    public Task<DeviceMismatchListResult> ListDevicesWithImeiIccidMismatch(DeviceMismatchListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/list/imeiiccidmismatch"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceMismatchListResult>(),
            ListDevicesWithImeiIccidMismatchErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Move devices between accounts.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MoveDevicesWithinAccountsOfProfileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Move active devices from one billing account to another within a customer profile.
    /// </remarks>
    public Task<DeviceManagementResult> MoveDevicesWithinAccountsOfProfile(MoveDeviceRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/move"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            MoveDevicesWithinAccountsOfProfileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Restore service to one or more suspended devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RestoreServiceForSuspendedDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Restores service to one or more suspended devices.
    /// </remarks>
    public Task<DeviceManagementResult> RestoreServiceForSuspendedDevices(CarrierActionsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/restore"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            RestoreServiceForSuspendedDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns the total amount of data sent and the total number of SMS messages sent or received by a set of devices in a specified timeframe.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RetrieveAggregateDeviceUsageHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The information is returned in a callback response, so you must register a URL for DeviceUsage callback messages using the POST /callbacks API.
    /// </remarks>
    public Task<DeviceManagementResult> RetrieveAggregateDeviceUsageHistory(DeviceAggregateUsageListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/usage/actions/list/aggregate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            RetrieveAggregateDeviceUsageHistoryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns a list of network connection events for a device during a specified time period.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectionHistoryResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RetrieveDeviceConnectionHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Each response includes a maximum of 500 records. To obtain more records, you can call the API multiple times, adjusting the earliest value each time to start where the previous request finished.
    /// </remarks>
    public Task<ConnectionHistoryResult> RetrieveDeviceConnectionHistory(DeviceConnectionListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/connections/actions/listHistory"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ConnectionHistoryResult>(),
            RetrieveDeviceConnectionHistoryErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Suspends service for one or more devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SuspendServiceForDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Suspends service for one or more devices.
    /// </remarks>
    public Task<DeviceManagementResult> SuspendServiceForDevices(CarrierActionsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/suspend"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            SuspendServiceForDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service.
    /// </summary>
    /// <param name="serviceType">Identifier type.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateDeviceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the identifier of a 3G or 4G device to match hardware changes made for a line of service. Use this request to transfer the line of service and the MDN to new hardware, or to change the MDN.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDeviceId(string serviceType,
        ChangeDeviceIdRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/{serviceType}/actions/deviceId"),
            [new TemplateParam("serviceType", serviceType)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDeviceIdErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Changes the name and address associated with a device.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateDevicesContactInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a CarrierService callback message for each device in the request when the contact information has been changed, or if there was a problem and the change could not be completed.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesContactInformation(ContactInfoUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/contactInfo"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesContactInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Changes or removes the costCenterCode value for one or more devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateDevicesCostCenterCodeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes or removes the CostCenterCode value or customer name and address (Primary Place of Use) for one or more devices.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesCostCenterCode(DeviceCostCenterRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/costCenter"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesCostCenterCodeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Updates one or more custom field values for devices.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateDevicesCustomFieldsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a CarrierService callback message for each device in the request when the custom fields have been changed, or if there was a problem and the change could not be completed.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesCustomFields(CustomFieldsUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/customFields"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesCustomFieldsErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Move devices to a new customer-defined state.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateDevicesStateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the provisioning state of one or more devices to a specified customer-defined service and state.
    /// </remarks>
    public Task<DeviceManagementResult> UpdateDevicesState(GoToStateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/gotostate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UpdateDevicesStateErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Uploads and activates device.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UploadActivateDeviceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads and activates device identifiers and SKUs for new devices from OEMs to Verizon.
    /// </remarks>
    public Task<DeviceManagementResult> UploadActivateDevice(UploadsActivatesDeviceRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/uploadactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UploadActivateDeviceErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Allow you to associate a label to a device
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UsageSegmentationLabelAssociationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows you to associate your own usage segmentation label with a device.
    /// </remarks>
    public Task<DeviceManagementResult> UsageSegmentationLabelAssociation(AssociateLabelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/usagesegmentationlabels"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeviceManagementResult>(),
            UsageSegmentationLabelAssociationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Allow you to remove the label associated with a device.
    /// </summary>
    /// <param name="accountName">The numeric name of the account.</param>
    /// <param name="labelList">A list of the Label IDs to remove from the exclusion list.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceManagementResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UsageSegmentationLabelDeletionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allow customers to remove the associated label from a device.
    /// </remarks>
    public Task<DeviceManagementResult> UsageSegmentationLabelDeletion(string accountName,
        LabelsList labelList,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/actions/usagesegmentationlabels"),
            [],
            [new Param("accountName", accountName), new Param("LabelList", labelList)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceManagementResult>(),
            UsageSegmentationLabelDeletionErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
