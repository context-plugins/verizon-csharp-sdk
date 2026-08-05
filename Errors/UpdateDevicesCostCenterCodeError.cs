using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateDevicesCostCenterCodeError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private UpdateDevicesCostCenterCodeError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static UpdateDevicesCostCenterCodeError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static UpdateDevicesCostCenterCodeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<UpdateDevicesCostCenterCodeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateDevicesCostCenterCodeErrorResponse : IErrorResponse<UpdateDevicesCostCenterCodeError>
{
    public static UpdateDevicesCostCenterCodeErrorResponse Instance { get; } = new();

    private UpdateDevicesCostCenterCodeErrorResponse()
    {
    }

    public Task<UpdateDevicesCostCenterCodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateDevicesCostCenterCodeError.Create(response, ct);
}
