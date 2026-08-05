using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RetrieveAggregateDeviceUsageHistoryError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private RetrieveAggregateDeviceUsageHistoryError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static RetrieveAggregateDeviceUsageHistoryError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static RetrieveAggregateDeviceUsageHistoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<RetrieveAggregateDeviceUsageHistoryError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RetrieveAggregateDeviceUsageHistoryErrorResponse : IErrorResponse<RetrieveAggregateDeviceUsageHistoryError>
{
    public static RetrieveAggregateDeviceUsageHistoryErrorResponse Instance { get; } = new();

    private RetrieveAggregateDeviceUsageHistoryErrorResponse()
    {
    }

    public Task<RetrieveAggregateDeviceUsageHistoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RetrieveAggregateDeviceUsageHistoryError.Create(response, ct);
}
