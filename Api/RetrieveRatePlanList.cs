using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core;
using Verizon.Core.Authentication;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Exceptions;
using Verizon.Core.Models;
using Verizon.Core.Request;
using Verizon.Core.Response;
using Verizon.Models;

namespace Verizon.Api;

/// <summary>
/// Retrive a list of the rate plans associated with the account
/// </summary>
public sealed class RetrieveRatePlanList
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RetrieveRatePlanList(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get rate plan list
    /// </summary>
    /// <param name="ecpdId">The Enterprise Customer Profile Database ID. This is the same as the accountName value</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Rateplan"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the rate plans and rate plan details for a profile ID.
    /// </remarks>
    public Task<Rateplan> GetRatePlanList(string ecpdId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/v2/triggers/rateplanlist/{ecpdId}"),
            [new TemplateParam("ecpdId", ecpdId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Rateplan>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThingspaceOauth1, _auth.VzM2MToken)],
            requestOptions,
            ct);
}
