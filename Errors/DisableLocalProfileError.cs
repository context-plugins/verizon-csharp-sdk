using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DisableLocalProfileError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private DisableLocalProfileError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static DisableLocalProfileError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static DisableLocalProfileError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<DisableLocalProfileError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DisableLocalProfileErrorResponse : IErrorResponse<DisableLocalProfileError>
{
    public static DisableLocalProfileErrorResponse Instance { get; } = new();

    private DisableLocalProfileErrorResponse()
    {
    }

    public Task<DisableLocalProfileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DisableLocalProfileError.Create(response, ct);
}
