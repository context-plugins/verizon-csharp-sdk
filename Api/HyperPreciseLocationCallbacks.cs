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

namespace Verizon.Api;

/// <summary>
/// Manage callback listeners for Hyper Precise
/// </summary>
public sealed class HyperPreciseLocationCallbacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal HyperPreciseLocationCallbacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Deregister a Callback Listener
    /// </summary>
    /// <param name="accountNumber">The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.</param>
    /// <param name="service">The name of the callback service that will be deleted.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeregisterCallback6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Stops ThingSpace from sending callback messages for the specified account and listener name.
    /// </remarks>
    public Task DeregisterCallback6(string accountNumber,
        string service,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/callbacks"),
            [],
            [new Param("accountNumber", accountNumber), new Param("service", service)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeregisterCallback6ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get registered callback listener
    /// </summary>
    /// <param name="accountNumber">The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CallbackCreated"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListRegisteredCallbacks6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Find registered callback listener for account by account number.
    /// </remarks>
    public Task<IReadOnlyList<CallbackCreated>> ListRegisteredCallbacks6(string accountNumber,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/callbacks"),
            [],
            [new Param("accountNumber", accountNumber)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CallbackCreated>>(),
            ListRegisteredCallbacks6ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Register a Callback Listener URL
    /// </summary>
    /// <param name="accountNumber">A unique identifier for an account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CallbackRegistered"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RegisterCallback6Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.
    /// </remarks>
    public Task<CallbackRegistered> RegisterCallback6(string accountNumber,
        HyperPreciseLocationCallback body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/callbacks"),
            [],
            [new Param("accountNumber", accountNumber)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CallbackRegistered>(),
            RegisterCallback6ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
