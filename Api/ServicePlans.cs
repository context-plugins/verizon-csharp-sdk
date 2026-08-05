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
/// Get a list of service plans in an account.
/// </summary>
public sealed class ServicePlans
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ServicePlans(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Returns a list of all data service plans that are associated with a specified account.
    /// </summary>
    /// <param name="aname">Account name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ServicePlan"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListAccountServicePlansError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.
    /// </remarks>
    public Task<IReadOnlyList<ServicePlan>> ListAccountServicePlans(string aname,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/m2m/v1/plans/{aname}"),
            [new TemplateParam("aname", aname)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ServicePlan>>(),
            ListAccountServicePlansErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
