using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ProfileToActivateDeviceError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private ProfileToActivateDeviceError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static ProfileToActivateDeviceError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static ProfileToActivateDeviceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<ProfileToActivateDeviceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ProfileToActivateDeviceErrorResponse : IErrorResponse<ProfileToActivateDeviceError>
{
    public static ProfileToActivateDeviceErrorResponse Instance { get; } = new();

    private ProfileToActivateDeviceErrorResponse()
    {
    }

    public Task<ProfileToActivateDeviceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ProfileToActivateDeviceError.Create(response, ct);
}
