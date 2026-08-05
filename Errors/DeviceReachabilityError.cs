using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeviceReachabilityError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private DeviceReachabilityError(Optional<RestErrorResponse> restErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static DeviceReachabilityError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static DeviceReachabilityError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<DeviceReachabilityError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeviceReachabilityErrorResponse : IErrorResponse<DeviceReachabilityError>
{
    public static DeviceReachabilityErrorResponse Instance { get; } = new();

    private DeviceReachabilityErrorResponse()
    {
    }

    public Task<DeviceReachabilityError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeviceReachabilityError.Create(response, ct);
}
