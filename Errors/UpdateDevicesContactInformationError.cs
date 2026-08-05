using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateDevicesContactInformationError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private UpdateDevicesContactInformationError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static UpdateDevicesContactInformationError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static UpdateDevicesContactInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<UpdateDevicesContactInformationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateDevicesContactInformationErrorResponse : IErrorResponse<UpdateDevicesContactInformationError>
{
    public static UpdateDevicesContactInformationErrorResponse Instance { get; } = new();

    private UpdateDevicesContactInformationErrorResponse()
    {
    }

    public Task<UpdateDevicesContactInformationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateDevicesContactInformationError.Create(response, ct);
}
