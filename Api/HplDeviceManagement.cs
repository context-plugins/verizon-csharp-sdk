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
/// Manage the devices on the account
/// </summary>
public sealed class HplDeviceManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal HplDeviceManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Adds up to 200 new devices, without provisioning lines of service for them.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="HplAddDevicesRequest"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddDevicesHyperPreciseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this API if you want to manage some device settings before you are ready to activate service for the devices.
    /// </remarks>
    public Task<IReadOnlyList<HplAddDevicesRequest>> AddDevicesHyperPrecise(HplAddDevicesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseLocation("/devices/actions/add"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<HplAddDevicesRequest>>(),
            AddDevicesHyperPreciseErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
