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
/// Assign Software Management Services license to devices <b>Note:</b>These endpoints have been deprecated. Please use the <b>v3</b> endpoints.
/// </summary>
public sealed class SoftwareManagementLicensesV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementLicensesV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Assign licenses to devices
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AssignLicensesToDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.
    /// </remarks>
    public Task<V1LicensesAssignedRemovedResult> AssignLicensesToDevices(string account,
        V1LicensesAssignedRemovedRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/licenses/{account}/assign"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1LicensesAssignedRemovedResult>(),
            AssignLicensesToDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1ListOfLicensesToRemoveResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateListOfLicensesToRemoveError"/> when the server returns an error response.</exception>
    public Task<V1ListOfLicensesToRemoveResult> CreateListOfLicensesToRemove(string account,
        V1ListOfLicensesToRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/licenses/{account}/cancel"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1ListOfLicensesToRemoveResult>(),
            CreateListOfLicensesToRemoveErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Remove all devices from the cancellation candidate list
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteListOfLicensesToRemoveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the entire list of cancellation candidate devices.
    /// </remarks>
    public Task DeleteListOfLicensesToRemove(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/licenses/{account}/cancel"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteListOfLicensesToRemoveErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get cancellation candidate list
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="startIndex">The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1ListOfLicensesToRemove"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListLicensesToRemoveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
    /// </remarks>
    public Task<V1ListOfLicensesToRemove> ListLicensesToRemove(string account,
        string startIndex,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/licenses/{account}/cancel/index/{startIndex}"),
            [new TemplateParam("account", account), new TemplateParam("startIndex", startIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1ListOfLicensesToRemove>(),
            ListLicensesToRemoveErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Remove licenses from device
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1LicensesAssignedRemovedResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveLicensesFromDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove unused licenses from device.
    /// </remarks>
    public Task<V1LicensesAssignedRemovedResult> RemoveLicensesFromDevices(string account,
        V1LicensesAssignedRemovedRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/licenses/{account}/remove"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1LicensesAssignedRemovedResult>(),
            RemoveLicensesFromDevicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
