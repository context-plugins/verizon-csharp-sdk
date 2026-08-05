using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CalculateAggregatedReportSynchronousError : ApiError
{
    private readonly Optional<HyperPreciseLocationResult> _hyperPreciseLocationResultValue;

    private CalculateAggregatedReportSynchronousError(Optional<HyperPreciseLocationResult> hyperPreciseLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _hyperPreciseLocationResultValue = hyperPreciseLocationResultValue;
    }

    private static CalculateAggregatedReportSynchronousError AsHyperPreciseLocationResult(HyperPreciseLocationResult value) =>
        new(Optional<HyperPreciseLocationResult>.Some(value), default);

    private static CalculateAggregatedReportSynchronousError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult value) =>
        _hyperPreciseLocationResultValue.TryGetValue(out value);

    internal static Task<CalculateAggregatedReportSynchronousError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 409 or 500 => FromJson<HyperPreciseLocationResult>(response, ct).As(AsHyperPreciseLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CalculateAggregatedReportSynchronousErrorResponse : IErrorResponse<CalculateAggregatedReportSynchronousError>
{
    public static CalculateAggregatedReportSynchronousErrorResponse Instance { get; } = new();

    private CalculateAggregatedReportSynchronousErrorResponse()
    {
    }

    public Task<CalculateAggregatedReportSynchronousError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CalculateAggregatedReportSynchronousError.Create(response, ct);
}
