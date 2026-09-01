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

public sealed class DeviceRoleController
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeviceRoleController(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get access rules based on the Vendor ID
    /// </summary>
    /// <param name="vendorId">The user's Vendor ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DeviceRole"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAclRulesByVendorIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API allows the user to get the access control rules defined for them.
    /// </remarks>
    public Task<IReadOnlyList<DeviceRole>> GetAclRulesByVendorId(string vendorId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.ImpServer("/api/v1/device-roles/vendor"),
            [],
            [new Param("VendorID", vendorId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DeviceRole>>(),
            GetAclRulesByVendorIdErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            ct);
}
