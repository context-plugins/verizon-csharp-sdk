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
using Verizon.Models.Enums;

namespace Verizon.Api;

/// <summary>
/// Register and deregister callback endpoints.
/// </summary>
public sealed class SoftwareManagementCallbacksV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementCallbacksV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Deregister a callback endpoint
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="service">Callback type. Must be 'Fota' for Software Management Services API.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeregisterCallback3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.
    /// </remarks>
    public Task DeregisterCallback3(string account,
        CallbackService service,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/callbacks/{account}/name/{service}"),
            [new TemplateParam("account", account), new TemplateParam("service", service)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeregisterCallback3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get registered callback endpoints
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="RegisteredCallbacks"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListRegisteredCallbacks3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the name and endpoint URL of the callback listening services registered for a given account.
    /// </remarks>
    public Task<IReadOnlyList<RegisteredCallbacks>> ListRegisteredCallbacks3(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/callbacks/{account}"),
            [new TemplateParam("account", account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<RegisteredCallbacks>>(),
            ListRegisteredCallbacks3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Register a Callback Listener URL
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV1CallbackRegistrationResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RegisterCallback3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.
    /// </remarks>
    public Task<FotaV1CallbackRegistrationResult> RegisterCallback3(string account,
        FotaV1CallbackRegistrationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/callbacks/{account}"),
            [new TemplateParam("account", account)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<FotaV1CallbackRegistrationResult>(),
            RegisterCallback3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
