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
/// Get information about an account or account leads.
/// </summary>
public sealed class Accounts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Accounts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns information about a specified account
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Account"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountInformationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a specified account.
    /// </remarks>
    public Task<Account> GetAccountInformation(string aname,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/accounts/{aname}"),
            [new TemplateParam("aname", aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Account>(),
            GetAccountInformationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns information for all leads associated with the account
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="next">Continue the previous query from the pageUrl in Location Header.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountLeadsResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountLeadsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When HTTP status is 202, a URL will be returned in the Location header of the form /leads/{aname}?next={token}. This URL can be used to request the next set of leads.
    /// </remarks>
    public Task<AccountLeadsResult> ListAccountLeads(string aname,
        long? next,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/leads/{aname}"),
            [new TemplateParam("aname", aname)],
            [new Param("next", next)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountLeadsResult>(),
            ListAccountLeadsErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Returns an account's custom services and states
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountStatesAndServices"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountStatesAndServicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list and details of all custom services and states defined for a specified account.
    /// </remarks>
    public Task<AccountStatesAndServices> ListAccountStatesAndServices(string aname,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/accounts/{aname}/statesandservices"),
            [new TemplateParam("aname", aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountStatesAndServices>(),
            ListAccountStatesAndServicesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
