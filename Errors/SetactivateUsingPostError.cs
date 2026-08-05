using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SetactivateUsingPostError : ApiError
{
    private readonly Optional<ESimrestErrorResponse> _esimrestErrorResponseValue;

    private SetactivateUsingPostError(Optional<ESimrestErrorResponse> esimrestErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _esimrestErrorResponseValue = esimrestErrorResponseValue;
    }

    private static SetactivateUsingPostError AsEsimrestErrorResponse(ESimrestErrorResponse value) =>
        new(Optional<ESimrestErrorResponse>.Some(value), default);

    private static SetactivateUsingPostError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEsimrestErrorResponse(out ESimrestErrorResponse value) =>
        _esimrestErrorResponseValue.TryGetValue(out value);

    internal static Task<SetactivateUsingPostError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<ESimrestErrorResponse>(response, ct).As(AsEsimrestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetactivateUsingPostErrorResponse : IErrorResponse<SetactivateUsingPostError>
{
    public static SetactivateUsingPostErrorResponse Instance { get; } = new();

    private SetactivateUsingPostErrorResponse()
    {
    }

    public Task<SetactivateUsingPostError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetactivateUsingPostError.Create(response, ct);
}
