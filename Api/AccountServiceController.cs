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
/// Account Information for a specified Account Name.
/// </summary>
public sealed class AccountServiceController
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountServiceController(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieve Account Information
    /// </summary>
    /// <param name="accountName">The account's numeric name, including leading zeroes.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAccountInformationResponseforplanner"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountInformationUsingGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns aaccount information associated with a specified account.
    /// </remarks>
    public Task<GetAccountInformationResponseforplanner> GetAccountInformationUsingGet(string accountName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/v1/accounts/{accountName}"),
            [new TemplateParam("accountName", accountName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAccountInformationResponseforplanner>(),
            GetAccountInformationUsingGetErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
