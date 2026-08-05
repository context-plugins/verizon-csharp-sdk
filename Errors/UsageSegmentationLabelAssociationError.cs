using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UsageSegmentationLabelAssociationError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private UsageSegmentationLabelAssociationError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static UsageSegmentationLabelAssociationError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static UsageSegmentationLabelAssociationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<UsageSegmentationLabelAssociationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UsageSegmentationLabelAssociationErrorResponse : IErrorResponse<UsageSegmentationLabelAssociationError>
{
    public static UsageSegmentationLabelAssociationErrorResponse Instance { get; } = new();

    private UsageSegmentationLabelAssociationErrorResponse()
    {
    }

    public Task<UsageSegmentationLabelAssociationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UsageSegmentationLabelAssociationError.Create(response, ct);
}
