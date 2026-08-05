using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UsageSegmentationLabelDeletionError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private UsageSegmentationLabelDeletionError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static UsageSegmentationLabelDeletionError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static UsageSegmentationLabelDeletionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<UsageSegmentationLabelDeletionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UsageSegmentationLabelDeletionErrorResponse : IErrorResponse<UsageSegmentationLabelDeletionError>
{
    public static UsageSegmentationLabelDeletionErrorResponse Instance { get; } = new();

    private UsageSegmentationLabelDeletionErrorResponse()
    {
    }

    public Task<UsageSegmentationLabelDeletionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UsageSegmentationLabelDeletionError.Create(response, ct);
}
