using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetDeviceServiceSuspensionStatusError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private GetDeviceServiceSuspensionStatusError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static GetDeviceServiceSuspensionStatusError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static GetDeviceServiceSuspensionStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<GetDeviceServiceSuspensionStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDeviceServiceSuspensionStatusErrorResponse : IErrorResponse<GetDeviceServiceSuspensionStatusError>
{
    public static GetDeviceServiceSuspensionStatusErrorResponse Instance { get; } = new();

    private GetDeviceServiceSuspensionStatusErrorResponse()
    {
    }

    public Task<GetDeviceServiceSuspensionStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDeviceServiceSuspensionStatusError.Create(response, ct);
}
