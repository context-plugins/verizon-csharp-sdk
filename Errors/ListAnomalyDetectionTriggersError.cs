using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAnomalyDetectionTriggersError : ApiError
{
    private readonly Optional<IntelligenceResult> _intelligenceResultValue;

    private ListAnomalyDetectionTriggersError(Optional<IntelligenceResult> intelligenceResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _intelligenceResultValue = intelligenceResultValue;
    }

    private static ListAnomalyDetectionTriggersError AsIntelligenceResult(IntelligenceResult value) =>
        new(Optional<IntelligenceResult>.Some(value), default);

    private static ListAnomalyDetectionTriggersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetIntelligenceResult(out IntelligenceResult value) =>
        _intelligenceResultValue.TryGetValue(out value);

    internal static Task<ListAnomalyDetectionTriggersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<IntelligenceResult>(response, ct).As(AsIntelligenceResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAnomalyDetectionTriggersErrorResponse : IErrorResponse<ListAnomalyDetectionTriggersError>
{
    public static ListAnomalyDetectionTriggersErrorResponse Instance { get; } = new();

    private ListAnomalyDetectionTriggersErrorResponse()
    {
    }

    public Task<ListAnomalyDetectionTriggersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAnomalyDetectionTriggersError.Create(response, ct);
}
