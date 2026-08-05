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
public sealed class SoftwareManagementLicensesV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementLicensesV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Assign FOTA licenses to devices
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AssignLicensesToDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to assign licenses to a list of devices.
    /// </remarks>
    public Task<V2LicensesAssignedRemovedResult> AssignLicensesToDevices2(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/licenses/{account}/assign"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V2LicensesAssignedRemovedResult>(),
            AssignLicensesToDevices2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Create a list of license cancellation candidate devices
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2ListOfLicensesToRemoveResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateListOfLicensesToRemove2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The license cancel endpoint allows user to create a list of license cancellation candidate devices.
    /// </remarks>
    public Task<V2ListOfLicensesToRemoveResult> CreateListOfLicensesToRemove2(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/licenses/{account}/cancel"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V2ListOfLicensesToRemoveResult>(),
            CreateListOfLicensesToRemove2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a previously created cancel candidate device list
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2SuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteListOfLicensesToRemove2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a created cancel candidate device list.
    /// </remarks>
    public Task<FotaV2SuccessResult> DeleteListOfLicensesToRemove2(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/licenses/{account}/cancel"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2SuccessResult>(),
            DeleteListOfLicensesToRemove2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Summarize FOTA licenses assignment
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="lastSeenDeviceId">Last seen device identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2LicenseSummary"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountLicenseStatus2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The endpoint allows user to list license usage.
    /// </remarks>
    public Task<V2LicenseSummary> GetAccountLicenseStatus2(string account,
        string? lastSeenDeviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/licenses/{account}"),
            [new TemplateParam("account", account)],
            [new Param("lastSeenDeviceId", lastSeenDeviceId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2LicenseSummary>(),
            GetAccountLicenseStatus2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a list of license cancellation candidate devices
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="startIndex">Start index to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2ListOfLicensesToRemove"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListLicensesToRemove2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The license cancel endpoint allows user to list registered license cancellation candidate devices.
    /// </remarks>
    public Task<V2ListOfLicensesToRemove> ListLicensesToRemove2(string account,
        string? startIndex,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/licenses/{account}/cancel"),
            [new TemplateParam("account", account)],
            [new Param("startIndex", startIndex)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V2ListOfLicensesToRemove>(),
            ListLicensesToRemove2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Remove licenses from devices
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V2LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveLicensesFromDevices2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to remove licenses from a list of devices.
    /// </remarks>
    public Task<V2LicensesAssignedRemovedResult> RemoveLicensesFromDevices2(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/licenses/{account}/remove"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V2LicensesAssignedRemovedResult>(),
            RemoveLicensesFromDevices2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
