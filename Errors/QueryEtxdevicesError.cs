using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class QueryEtxdevicesError : ApiError
{
    private readonly Optional<EtxrespondingError> _etxrespondingErrorValue;

    private QueryEtxdevicesError(Optional<EtxrespondingError> etxrespondingErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _etxrespondingErrorValue = etxrespondingErrorValue;
    }

    private static QueryEtxdevicesError AsEtxrespondingError(EtxrespondingError value) =>
        new(Optional<EtxrespondingError>.Some(value), default);

    private static QueryEtxdevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxrespondingError(out EtxrespondingError value) =>
        _etxrespondingErrorValue.TryGetValue(out value);

    internal static Task<QueryEtxdevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 500 => FromJson<EtxrespondingError>(response, ct).As(AsEtxrespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryEtxdevicesErrorResponse : IErrorResponse<QueryEtxdevicesError>
{
    public static QueryEtxdevicesErrorResponse Instance { get; } = new();

    private QueryEtxdevicesErrorResponse()
    {
    }

    public Task<QueryEtxdevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryEtxdevicesError.Create(response, ct);
}
