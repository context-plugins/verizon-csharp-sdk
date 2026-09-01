using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class QueryEtxDevicesError : ApiError
{
    private readonly Optional<EtxRespondingError> _etxRespondingErrorValue;

    private QueryEtxDevicesError(Optional<EtxRespondingError> etxRespondingErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _etxRespondingErrorValue = etxRespondingErrorValue;
    }

    private static QueryEtxDevicesError AsEtxRespondingError(EtxRespondingError value) =>
        new(Optional<EtxRespondingError>.Some(value), default);

    private static QueryEtxDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxRespondingError(out EtxRespondingError value) =>
        _etxRespondingErrorValue.TryGetValue(out value);

    internal static Task<QueryEtxDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 500 => FromJson<EtxRespondingError>(response, ct).As(AsEtxRespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryEtxDevicesErrorResponse : IErrorResponse<QueryEtxDevicesError>
{
    public static QueryEtxDevicesErrorResponse Instance { get; } = new();

    private QueryEtxDevicesErrorResponse()
    {
    }

    public Task<QueryEtxDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryEtxDevicesError.Create(response, ct);
}
