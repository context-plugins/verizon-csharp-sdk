using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetDeviceGroupInformationError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private GetDeviceGroupInformationError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static GetDeviceGroupInformationError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static GetDeviceGroupInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<GetDeviceGroupInformationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDeviceGroupInformationErrorResponse : IErrorResponse<GetDeviceGroupInformationError>
{
    public static GetDeviceGroupInformationErrorResponse Instance { get; } = new();

    private GetDeviceGroupInformationErrorResponse()
    {
    }

    public Task<GetDeviceGroupInformationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDeviceGroupInformationError.Create(response, ct);
}
