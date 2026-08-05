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
/// Information about current FOTA subscriptions.
/// </summary>
public sealed class SoftwareManagementSubscriptionsV3
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementSubscriptionsV3(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a FOTA subscription
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FotaV3Subscription"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountSubscriptionStatus3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint retrieves a FOTA subscription by account.
    /// </remarks>
    public Task<FotaV3Subscription> GetAccountSubscriptionStatus3(string acc,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV3("/subscriptions/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FotaV3Subscription>(),
            GetAccountSubscriptionStatus3ErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
