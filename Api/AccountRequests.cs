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
/// Get the status of asynchronous reqeusts.
/// </summary>
public sealed class AccountRequests
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountRequests(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns the status of an asynchronous request
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="requestId">UUID from synchronous response.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AsynchronousRequestResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCurrentAsynchronousRequestStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the current status of an asynchronous request that was made for a single device.
    /// </remarks>
    public Task<AsynchronousRequestResult> GetCurrentAsynchronousRequestStatus(string aname,
        string requestId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/accounts/{aname}/requests/{requestId}/status"),
            [new TemplateParam("aname", aname), new TemplateParam("requestId", requestId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AsynchronousRequestResult>(),
            GetCurrentAsynchronousRequestStatusErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
