using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SetdeactivateUsingPostError : ApiError
{
    private readonly Optional<ESimrestErrorResponse> _esimrestErrorResponseValue;

    private SetdeactivateUsingPostError(Optional<ESimrestErrorResponse> esimrestErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _esimrestErrorResponseValue = esimrestErrorResponseValue;
    }

    private static SetdeactivateUsingPostError AsEsimrestErrorResponse(ESimrestErrorResponse value) =>
        new(Optional<ESimrestErrorResponse>.Some(value), default);

    private static SetdeactivateUsingPostError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEsimrestErrorResponse(out ESimrestErrorResponse value) =>
        _esimrestErrorResponseValue.TryGetValue(out value);

    internal static Task<SetdeactivateUsingPostError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<ESimrestErrorResponse>(response, ct).As(AsEsimrestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetdeactivateUsingPostErrorResponse : IErrorResponse<SetdeactivateUsingPostError>
{
    public static SetdeactivateUsingPostErrorResponse Instance { get; } = new();

    private SetdeactivateUsingPostErrorResponse()
    {
    }

    public Task<SetdeactivateUsingPostError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetdeactivateUsingPostError.Create(response, ct);
}
