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
public sealed class SoftwareManagementCallbacksV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementCallbacksV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a previously registered Callback
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3SuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeregisterCallback5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to delete a previously registered callback URL.
    /// </remarks>
    public Task<FotaV3SuccessResult> DeregisterCallback5(string acc,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/callbacks/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV3SuccessResult>(),
            DeregisterCallback5ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get the registered callback information
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3CallbackSummary"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListRegisteredCallbacks5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to get the registered callback information.
    /// </remarks>
    public Task<FotaV3CallbackSummary> ListRegisteredCallbacks5(string acc,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/callbacks/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV3CallbackSummary>(),
            ListRegisteredCallbacks5ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Create HTTPS callback address
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RegisterCallback5Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows the user to create the HTTPS callback address.
    /// </remarks>
    public Task<FotaV3CallbackRegistrationResult> RegisterCallback5(string acc,
        FotaV3CallbackRegistrationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/callbacks/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<FotaV3CallbackRegistrationResult>(),
            RegisterCallback5ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Update HTTPS callback address
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCallback2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows the user to update the HTTPS callback address.
    /// </remarks>
    public Task<FotaV3CallbackRegistrationResult> UpdateCallback2(string acc,
        FotaV3CallbackRegistrationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/callbacks/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<FotaV3CallbackRegistrationResult>(),
            UpdateCallback2ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
