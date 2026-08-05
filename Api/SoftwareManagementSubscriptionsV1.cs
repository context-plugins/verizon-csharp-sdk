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
/// View Software Management Services subscription status.
/// </summary>
public sealed class SoftwareManagementSubscriptionsV1
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SoftwareManagementSubscriptionsV1(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get account license information
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="startIndex">The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountLicenseInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountLicenseStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about an account's Software Management Services licenses and a list of licensed devices.
    /// </remarks>
    public Task<AccountLicenseInfo> GetAccountLicenseStatus(string account,
        string startIndex,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/licenses/{account}/index/{startIndex}"),
            [new TemplateParam("account", account), new TemplateParam("startIndex", startIndex)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountLicenseInfo>(),
            GetAccountLicenseStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get account subscription status
    /// </summary>
    /// <param name="account">Account identifier in "##########-#####".</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1AccountSubscription"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountSubscriptionStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This subscriptions endpoint retrieves an account's current Software Management Service subscription status.
    /// </remarks>
    public Task<V1AccountSubscription> GetAccountSubscriptionStatus(string account,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV1("/subscriptions/{account}"),
            [new TemplateParam("account", account)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1AccountSubscription>(),
            GetAccountSubscriptionStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
