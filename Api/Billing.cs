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

public sealed class Billing
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Billing(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Adds a list of accounts for managed billing to a primary account.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountsAddResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to add managed accounts to a primary account.
    /// </remarks>
    public Task<ManagedAccountsAddResponse> AddAccount(ManagedAccountsAddRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/managedaccounts/actions/add"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ManagedAccountsAddResponse>(),
            AddAccountErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a managed service for an account.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelManagedAccountActionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deactivates a managed billing service relationship between a managed account and the primary account.
    /// </remarks>
    public Task<ManagedAccountCancelResponse> CancelManagedAccountAction(ManagedAccountCancelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/managedaccounts/actions/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ManagedAccountCancelResponse>(),
            CancelManagedAccountActionErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get the list of all managed accounts
    /// </summary>
    /// <param name="accountName">Primary account identifier</param>
    /// <param name="serviceName">Service name</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountsGetAllResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListManagedAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows user to retrieve the list of all accounts managed by a primary account.
    /// </remarks>
    public Task<ManagedAccountsGetAllResponse> ListManagedAccount(string accountName,
        string serviceName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/managedaccounts/{accountName}/service/{serviceName}"),
            [new TemplateParam("accountName", accountName), new TemplateParam("serviceName", serviceName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ManagedAccountsGetAllResponse>(),
            ListManagedAccountErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Activate a specific managed account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagedAccountsProvisionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ManagedAccountActionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Activates a managed billing service relationship between a managed account and the primary account.
    /// </remarks>
    public Task<ManagedAccountsProvisionResponse> ManagedAccountAction(ManagedAccountsProvisionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SubscriptionServer("/managedaccounts/actions/provision"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ManagedAccountsProvisionResponse>(),
            ManagedAccountActionErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
