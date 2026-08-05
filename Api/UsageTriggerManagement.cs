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

public sealed class UsageTriggerManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsageTriggerManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    ///  Create a new usage trigger
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageTriggerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateNewTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.
    /// </remarks>
    public Task<UsageTriggerResponse> CreateNewTrigger(UsageTriggerAddRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/usage/triggers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UsageTriggerResponse>(),
            CreateNewTriggerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Deletes a usage trigger
    /// </summary>
    /// <param name="accountName">Account name</param>
    /// <param name="triggerId">Usage trigger ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceLocationSuccessResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// eletes the specified usage trigger from the given account
    /// </remarks>
    public Task<DeviceLocationSuccessResult> DeleteTrigger(string accountName,
        string triggerId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/usage/accounts/{accountName}/triggers/{triggerId}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("triggerId", triggerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceLocationSuccessResult>(),
            DeleteTriggerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Change the settings of an existing usage trigger
    /// </summary>
    /// <param name="triggerId">Usage trigger ID</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsageTriggerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateTriggerError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing usage trigger
    /// </remarks>
    public Task<UsageTriggerResponse> UpdateTrigger(string triggerId,
        UsageTriggerUpdateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/usage/triggers/{triggerId}"),
            [new TemplateParam("triggerId", triggerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UsageTriggerResponse>(),
            UpdateTriggerErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
