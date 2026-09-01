using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class NewactivatecodeError : ApiError
{
    private readonly Optional<ESimRestErrorResponse> _eSimRestErrorResponseValue;

    private NewactivatecodeError(Optional<ESimRestErrorResponse> eSimRestErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _eSimRestErrorResponseValue = eSimRestErrorResponseValue;
    }

    private static NewactivatecodeError AsESimRestErrorResponse(ESimRestErrorResponse value) =>
        new(Optional<ESimRestErrorResponse>.Some(value), default);

    private static NewactivatecodeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetESimRestErrorResponse(out ESimRestErrorResponse value) =>
        _eSimRestErrorResponseValue.TryGetValue(out value);

    internal static Task<NewactivatecodeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<ESimRestErrorResponse>(response, ct).As(AsESimRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NewactivatecodeErrorResponse : IErrorResponse<NewactivatecodeError>
{
    public static NewactivatecodeErrorResponse Instance { get; } = new();

    private NewactivatecodeErrorResponse()
    {
    }

    public Task<NewactivatecodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NewactivatecodeError.Create(response, ct);
}
