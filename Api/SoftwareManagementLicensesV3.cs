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
/// License status and assignment.
/// </summary>
public sealed class SoftwareManagementLicensesV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementLicensesV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Assign FOTA licenses to devices
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3LicenseAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AssignLicensesToDevices3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to assign licenses to a list of devices.
    /// </remarks>
    public Task<V3LicenseAssignedRemovedResult> AssignLicensesToDevices3(string acc,
        V3LicenseImei body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/licenses/{acc}/assign"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V3LicenseAssignedRemovedResult>(),
            AssignLicensesToDevices3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Summarize FOTA licenses assignment
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="lastSeenDeviceId">Last seen device identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3LicenseSummary"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountLicensesStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The endpoint allows user to list license usage.
    /// </remarks>
    public Task<V3LicenseSummary> GetAccountLicensesStatus(string acc,
        string? lastSeenDeviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/licenses/{acc}"),
            [new TemplateParam("acc", acc)],
            [new Param("lastSeenDeviceId", lastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V3LicenseSummary>(),
            GetAccountLicensesStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Remove licenses from devices
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V3LicenseAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveLicensesFromDevices3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to remove licenses from a list of devices.
    /// </remarks>
    public Task<V3LicenseAssignedRemovedResult> RemoveLicensesFromDevices3(string acc,
        V3LicenseImei body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/licenses/{acc}/remove"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V3LicenseAssignedRemovedResult>(),
            RemoveLicensesFromDevices3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
