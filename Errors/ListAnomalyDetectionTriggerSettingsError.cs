using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAnomalyDetectionTriggerSettingsError : ApiError
{
    private readonly Optional<IntelligenceResult> _intelligenceResultValue;

    private ListAnomalyDetectionTriggerSettingsError(Optional<IntelligenceResult> intelligenceResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _intelligenceResultValue = intelligenceResultValue;
    }

    private static ListAnomalyDetectionTriggerSettingsError AsIntelligenceResult(IntelligenceResult value) =>
        new(Optional<IntelligenceResult>.Some(value), default);

    private static ListAnomalyDetectionTriggerSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetIntelligenceResult(out IntelligenceResult value) =>
        _intelligenceResultValue.TryGetValue(out value);

    internal static Task<ListAnomalyDetectionTriggerSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<IntelligenceResult>(response, ct).As(AsIntelligenceResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAnomalyDetectionTriggerSettingsErrorResponse : IErrorResponse<ListAnomalyDetectionTriggerSettingsError>
{
    public static ListAnomalyDetectionTriggerSettingsErrorResponse Instance { get; } = new();

    private ListAnomalyDetectionTriggerSettingsErrorResponse()
    {
    }

    public Task<ListAnomalyDetectionTriggerSettingsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAnomalyDetectionTriggerSettingsError.Create(response, ct);
}
