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
/// Manage geofence-based application configurations.
/// </summary>
public sealed class EtxappConfiguration
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EtxappConfiguration(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a configuration
    /// </summary>
    /// <param name="vendorId">The vendor's identifier</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeoFenceConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<GeoFenceConfigurationResponse> CreateConfiguration(string vendorId,
        GeoFenceConfigurationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.ImpServer("/api/v1/application/configurations/geofence"),
            [],
            [],
            [new HeaderParam("VendorID", vendorId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GeoFenceConfigurationResponse>(),
            CreateConfigurationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a configuration
    /// </summary>
    /// <param name="id">The configuration identifier</param>
    /// <param name="vendorId">The vendor's identifier</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task DeleteConfiguration(string id,
        string vendorId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.ImpServer("/api/v1/application/configurations/geofence"),
            [],
            [new Param("id", id)],
            [new HeaderParam("VendorID", vendorId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteConfigurationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get a configuration by its identifier
    /// </summary>
    /// <param name="id">The configuration identifier</param>
    /// <param name="vendorId">The vendor's identifier</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeoFenceConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<GeoFenceConfigurationResponse> GetConfiguration(string id,
        string vendorId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.ImpServer("/api/v1/application/configurations/geofence"),
            [],
            [new Param("id", id)],
            [new HeaderParam("VendorID", vendorId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GeoFenceConfigurationResponse>(),
            GetConfigurationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            ct);

    /// <summary>
    /// Get all configurations by VendorID
    /// </summary>
    /// <param name="vendorId">The vendor's identifier</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ConfigurationListItem"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetConfigurationListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<ConfigurationListItem>> GetConfigurationList(string vendorId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.ImpServer("/api/v1/application/configurations/geofence/ids"),
            [],
            [],
            [new HeaderParam("VendorID", vendorId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ConfigurationListItem>>(),
            GetConfigurationListErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            ct);

    /// <summary>
    /// Update a configuration
    /// </summary>
    /// <param name="id">The configuration identifier</param>
    /// <param name="vendorId">The vendor's identifier</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.
    /// <para>
    /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
    /// </para>
    /// </remarks>
    public Task UpdateConfiguration(string id,
        string vendorId,
        GeoFenceConfigurationUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.ImpServer("/api/v1/application/configurations/geofence"),
            [],
            [new Param("id", id)],
            [new HeaderParam("VendorID", vendorId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            UpdateConfigurationErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.SessionToken],
            requestOptions,
            ct);
}
