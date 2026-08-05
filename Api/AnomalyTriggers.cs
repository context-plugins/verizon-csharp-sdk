using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Errors;
using Verizon.Models;

namespace Verizon.Api;

/// <summary>
/// Set the threshold of notification for anomalies detected.
/// </summary>
public sealed class AnomalyTriggers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AnomalyTriggers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create trigger based on the category.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnomalyDetectionTrigger"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateAnomalyDetectionTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This corresponds to the M2M-MC SOAP interface, ```CreateTrigger```.
    /// </remarks>
    public Task<AnomalyDetectionTrigger> CreateAnomalyDetectionTrigger(CreateTriggerRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/triggers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AnomalyDetectionTrigger>(),
            CreateAnomalyDetectionTriggerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a specific trigger value
    /// </summary>
    /// <param name="triggerId">The trigger ID to be deleted</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnomalyDetectionTrigger"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a specific trigger ID
    /// </remarks>
    public Task<AnomalyDetectionTrigger> DeleteAnomalyDetectionTrigger(string triggerId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/triggers/{triggerId}"),
            [new TemplateParam("triggerId", triggerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<AnomalyDetectionTrigger>(),
            RawErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Gets the trigger information related to a triggerId
    /// </summary>
    /// <param name="triggerId">trigger ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="GetTriggerResponseList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAnomalyDetectionTriggerSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
    /// </remarks>
    public Task<IReadOnlyList<GetTriggerResponseList>> ListAnomalyDetectionTriggerSettings(string triggerId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/triggers/{triggerId}"),
            [new TemplateParam("triggerId", triggerId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<GetTriggerResponseList>>(),
            ListAnomalyDetectionTriggerSettingsErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the triggers related to a Contact
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="GetTriggerResponseList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAnomalyDetectionTriggersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This corresponds to the M2M-MC SOAP interface, ```GetTriggers```.
    /// </remarks>
    public Task<IReadOnlyList<GetTriggerResponseList>> ListAnomalyDetectionTriggers(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/triggers"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<GetTriggerResponseList>>(),
            ListAnomalyDetectionTriggersErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Update trigger Operation.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnomalyDetectionTrigger"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateAnomalyDetectionTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This corresponds to the M2M-MC SOAP interface, ```UpdateTriggerRequest```.
    /// </remarks>
    public Task<AnomalyDetectionTrigger> UpdateAnomalyDetectionTrigger(UpdateTriggerRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/triggers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<AnomalyDetectionTrigger>(),
            UpdateAnomalyDetectionTriggerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
