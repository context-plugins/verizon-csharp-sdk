using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetEtxConnectionUrlError : ApiError
{
    private readonly Optional<EtxRespondingError> _etxRespondingErrorValue;

    private GetEtxConnectionUrlError(Optional<EtxRespondingError> etxRespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxRespondingErrorValue = etxRespondingErrorValue;
    }

    private static GetEtxConnectionUrlError AsEtxRespondingError(EtxRespondingError value) =>
        new(Optional<EtxRespondingError>.Some(value), default);

    private static GetEtxConnectionUrlError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxRespondingError(out EtxRespondingError value) =>
        _etxRespondingErrorValue.TryGetValue(out value);

    internal static Task<GetEtxConnectionUrlError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 503 => FromJson<EtxRespondingError>(response, ct).As(AsEtxRespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEtxConnectionUrlErrorResponse : IErrorResponse<GetEtxConnectionUrlError>
{
    public static GetEtxConnectionUrlErrorResponse Instance { get; } = new();

    private GetEtxConnectionUrlErrorResponse()
    {
    }

    public Task<GetEtxConnectionUrlError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEtxConnectionUrlError.Create(response, ct);
}
