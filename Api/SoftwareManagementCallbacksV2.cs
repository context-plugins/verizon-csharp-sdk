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
/// Find registered callbacks or create, update and delete a registered callback.
/// </summary>
public sealed class SoftwareManagementCallbacksV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementCallbacksV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a previously registered Callback
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2SuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeregisterCallback4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a previously registered callback URL.
    /// </remarks>
    public Task<FotaV2SuccessResult> DeregisterCallback4(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2SuccessResult>(),
            DeregisterCallback4ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get the registered callback information
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackSummary"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListRegisteredCallbacks4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get the registered callback information.
    /// </remarks>
    public Task<CallbackSummary> ListRegisteredCallbacks4(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CallbackSummary>(),
            ListRegisteredCallbacks4ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Create HTTPS callback address
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RegisterCallback4Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to create the HTTPS callback address.
    /// </remarks>
    public Task<FotaV2CallbackRegistrationResult> RegisterCallback4(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2CallbackRegistrationResult>(),
            RegisterCallback4ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Update HTTPS callback address
    /// </summary>
    /// <param name="account">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV2CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCallbackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to update the HTTPS callback address.
    /// </remarks>
    public Task<FotaV2CallbackRegistrationResult> UpdateCallback(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/callbacks/{account}"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV2CallbackRegistrationResult>(),
            UpdateCallbackErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
