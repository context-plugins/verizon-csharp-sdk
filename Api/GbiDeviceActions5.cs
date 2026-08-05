using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.Authentication;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Models;

namespace Verizon.Api;

/// <summary>
/// Activate devices or retrieve device attributes.
/// </summary>
public sealed class GbiDeviceActions5
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GbiDeviceActions5(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Change a Device's service plan.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GbiRequestResponse5"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change a device's service plan to use 5G BI.
    /// </remarks>
    public Task<GbiRequestResponse5> BusinessInternetServiceplanchange(GbichangeRequest5 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/actions/plan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<GbiRequestResponse5>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth, _auth.VzM2MToken)],
            requestOptions,
            ct);

    /// <summary>
    /// Activate a device.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GbiRequestResponse5"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the device's ICCID and IMEI to activate service.
    /// </remarks>
    public Task<GbiRequestResponse5> BusinessInternetactivateUsingPost(GbiactivateRequest5 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/actions/activate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GbiRequestResponse5>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth, _auth.VzM2MToken)],
            requestOptions,
            ct);

    /// <summary>
    /// List the 5G BI information for a device by ICCID.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GbideviceDetailsresponse5"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.
    /// </remarks>
    public Task<GbideviceDetailsresponse5> BusinessInternetlistDeviceInformation(GbideviceId5 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/actions/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GbideviceDetailsresponse5>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth, _auth.VzM2MToken)],
            requestOptions,
            ct);
}
