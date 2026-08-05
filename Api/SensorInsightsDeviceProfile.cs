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
/// Create and manage device profile information
/// </summary>
public sealed class SensorInsightsDeviceProfile
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SensorInsightsDeviceProfile(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create device profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateAprofileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a device profile
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> CreateAprofile(DtoConfigurationProfile body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/deviceConfigurationProfiles"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            CreateAprofileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete device profile
    /// </summary>
    /// <param name="deleterequest">payload for the delete request</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteAprofileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a device profile
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> DeleteAprofile(DtoConfigurationProfileDelete deleterequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/deviceConfigurationProfiles"),
            [],
            [],
            [new HeaderParam("deleterequest", deleterequest), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            DeleteAprofileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Query device profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryAprofileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a device profile for an individual device
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> QueryAprofile(ResourceResourceQuery body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/deviceConfigurationProfiles/actions/query"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            QueryAprofileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Partially update device profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DtoProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateAprofileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Partially update a device profile
    /// </remarks>
    public Task<IReadOnlyList<DtoProfileResponse>> UpdateAprofile(DtoConfigurationProfilePath body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.HyperPreciseCredentials("/dm/v1/deviceConfigurationProfiles"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<DtoProfileResponse>>(),
            UpdateAprofileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
