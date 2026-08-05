using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListDevicesUsageHistoryError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ListDevicesUsageHistoryError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ListDevicesUsageHistoryError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ListDevicesUsageHistoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ListDevicesUsageHistoryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListDevicesUsageHistoryErrorResponse : IErrorResponse<ListDevicesUsageHistoryError>
{
    public static ListDevicesUsageHistoryErrorResponse Instance { get; } = new();

    private ListDevicesUsageHistoryErrorResponse()
    {
    }

    public Task<ListDevicesUsageHistoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListDevicesUsageHistoryError.Create(response, ct);
}
