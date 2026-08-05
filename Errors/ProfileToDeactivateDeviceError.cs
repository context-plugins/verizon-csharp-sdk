using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ProfileToDeactivateDeviceError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private ProfileToDeactivateDeviceError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static ProfileToDeactivateDeviceError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static ProfileToDeactivateDeviceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<ProfileToDeactivateDeviceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ProfileToDeactivateDeviceErrorResponse : IErrorResponse<ProfileToDeactivateDeviceError>
{
    public static ProfileToDeactivateDeviceErrorResponse Instance { get; } = new();

    private ProfileToDeactivateDeviceErrorResponse()
    {
    }

    public Task<ProfileToDeactivateDeviceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ProfileToDeactivateDeviceError.Create(response, ct);
}
