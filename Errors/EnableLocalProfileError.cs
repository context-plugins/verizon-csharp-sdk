using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class EnableLocalProfileError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private EnableLocalProfileError(Optional<RestErrorResponse> restErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static EnableLocalProfileError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static EnableLocalProfileError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<EnableLocalProfileError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EnableLocalProfileErrorResponse : IErrorResponse<EnableLocalProfileError>
{
    public static EnableLocalProfileErrorResponse Instance { get; } = new();

    private EnableLocalProfileErrorResponse()
    {
    }

    public Task<EnableLocalProfileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EnableLocalProfileError.Create(response, ct);
}
