using System;
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

public sealed class ConfigurationFiles
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ConfigurationFiles(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Retrieves a list of available files.
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="distributionType">Filter the distributionType to only retrieve files for a specific distribution type.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrievesAvailableFilesResponseList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetListOfFilesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You can retrieve a list of configuration or supplementary of files for an account.
    /// </remarks>
    public Task<RetrievesAvailableFilesResponseList> GetListOfFiles(string acc,
        string distributionType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/files/{acc}"),
            [new TemplateParam("acc", acc)],
            [new Param("distributionType", distributionType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrievesAvailableFilesResponseList>(),
            GetListOfFilesErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);

    /// <summary>
    /// Uploads a configuration supplementary file for an account.
    /// </summary>
    /// <param name="acc">Account identifier.</param>
    /// <param name="fileupload"></param>
    /// <param name="fileVersion"></param>
    /// <param name="make"></param>
    /// <param name="model"></param>
    /// <param name="localTargetPath"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadConfigurationFilesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UploadConfigFileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a configuration/supplementary file for an account. ThingSpace generates a fileName after the upload and is returned in the response.
    /// </remarks>
    public Task<UploadConfigurationFilesResponse> UploadConfigFile(string acc,
        BinaryContent? fileupload,
        string? fileVersion,
        string? make,
        string? model,
        string? localTargetPath,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.SoftwareManagementV2("/files/{acc}"),
            [new TemplateParam("acc", acc)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create([new MultipartParam("fileupload", fileupload),
                    new MultipartParam("fileVersion", fileVersion),
                    new MultipartParam("make", make),
                    new MultipartParam("model", model),
                    new MultipartParam("localTargetPath", localTargetPath)]),
            JsonResponse.Create<UploadConfigurationFilesResponse>(),
            UploadConfigFileErrorResponse.Instance,
            [_auth.ThingspaceOauth, _auth.VzM2MToken],
            requestOptions,
            ct);
}
