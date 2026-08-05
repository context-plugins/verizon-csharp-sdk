using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RetrieveGlobalListError : ApiError
{
    private readonly Optional<ESimrestErrorResponse> _esimrestErrorResponseValue;

    private RetrieveGlobalListError(Optional<ESimrestErrorResponse> esimrestErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _esimrestErrorResponseValue = esimrestErrorResponseValue;
    }

    private static RetrieveGlobalListError AsEsimrestErrorResponse(ESimrestErrorResponse value) =>
        new(Optional<ESimrestErrorResponse>.Some(value), default);

    private static RetrieveGlobalListError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEsimrestErrorResponse(out ESimrestErrorResponse value) =>
        _esimrestErrorResponseValue.TryGetValue(out value);

    internal static Task<RetrieveGlobalListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<ESimrestErrorResponse>(response, ct).As(AsEsimrestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RetrieveGlobalListErrorResponse : IErrorResponse<RetrieveGlobalListError>
{
    public static RetrieveGlobalListErrorResponse Instance { get; } = new();

    private RetrieveGlobalListErrorResponse()
    {
    }

    public Task<RetrieveGlobalListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RetrieveGlobalListError.Create(response, ct);
}
