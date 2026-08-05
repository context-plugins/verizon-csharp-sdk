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

public sealed class AccountSubscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountSubscriptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns information about all the subscriptions for an account.
    /// </summary>
    /// <param name="xRequestId">Transaction Id.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SecuritySubscriptionResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountSubscriptionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the total number of SIM-Secure for IoT subscription licenses purchased for your account by license type, and lists the number of licenses assigned and available for each license type.
    /// </remarks>
    public Task<SecuritySubscriptionResult> ListAccountSubscriptions(string? xRequestId,
        SecuritySubscriptionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.M2M("/v1/accounts/subscriptions/actions/list"),
            [],
            [],
            [new HeaderParam("X-Request-ID", xRequestId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SecuritySubscriptionResult>(),
            ListAccountSubscriptionsErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
