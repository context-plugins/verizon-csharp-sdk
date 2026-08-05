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
/// Activate and Deactivate the SIM.
/// </summary>
public sealed class SimActions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SimActions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a new activation code.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimrequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NewactivatecodeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// System assign a new activation code to reactivate a deactivated device. <b>Note:</b> the previously assigned ICCID must be used to request a new activation code.
    /// </remarks>
    public Task<ESimrequestResponse> Newactivatecode(ESimprofileRequest2 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/renew_activation_code"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ESimrequestResponse>(),
            NewactivatecodeErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Activate a SIM.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimrequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetactivateUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to activate the SIM.
    /// </remarks>
    public Task<ESimrequestResponse> SetactivateUsingPost(ESimprofileRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ESimrequestResponse>(),
            SetactivateUsingPostErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Deactivate a SIM.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ESimrequestResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetdeactivateUsingPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the profile to deactivate the SIM.
    /// </remarks>
    public Task<ESimrequestResponse> SetdeactivateUsingPost(ProfileRequest2 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/devices/profile/actions/deactivate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ESimrequestResponse>(),
            SetdeactivateUsingPostErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
