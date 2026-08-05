using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeviceReachabilityStatusUsingPostError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private DeviceReachabilityStatusUsingPostError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static DeviceReachabilityStatusUsingPostError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static DeviceReachabilityStatusUsingPostError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<DeviceReachabilityStatusUsingPostError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeviceReachabilityStatusUsingPostErrorResponse : IErrorResponse<DeviceReachabilityStatusUsingPostError>
{
    public static DeviceReachabilityStatusUsingPostErrorResponse Instance { get; } = new();

    private DeviceReachabilityStatusUsingPostErrorResponse()
    {
    }

    public Task<DeviceReachabilityStatusUsingPostError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeviceReachabilityStatusUsingPostError.Create(response, ct);
}
