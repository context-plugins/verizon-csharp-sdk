using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ActivateDeviceThroughProfileError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private ActivateDeviceThroughProfileError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static ActivateDeviceThroughProfileError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static ActivateDeviceThroughProfileError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<ActivateDeviceThroughProfileError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActivateDeviceThroughProfileErrorResponse : IErrorResponse<ActivateDeviceThroughProfileError>
{
    public static ActivateDeviceThroughProfileErrorResponse Instance { get; } = new();

    private ActivateDeviceThroughProfileErrorResponse()
    {
    }

    public Task<ActivateDeviceThroughProfileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActivateDeviceThroughProfileError.Create(response, ct);
}
