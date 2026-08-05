using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class StopDeviceReachabilityError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private StopDeviceReachabilityError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static StopDeviceReachabilityError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static StopDeviceReachabilityError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<StopDeviceReachabilityError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class StopDeviceReachabilityErrorResponse : IErrorResponse<StopDeviceReachabilityError>
{
    public static StopDeviceReachabilityErrorResponse Instance { get; } = new();

    private StopDeviceReachabilityErrorResponse()
    {
    }

    public Task<StopDeviceReachabilityError> Map(HttpResponseMessage response, CancellationToken ct) =>
        StopDeviceReachabilityError.Create(response, ct);
}
