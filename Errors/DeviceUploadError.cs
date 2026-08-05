using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeviceUploadError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private DeviceUploadError(Optional<RestErrorResponse> restErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static DeviceUploadError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static DeviceUploadError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<DeviceUploadError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeviceUploadErrorResponse : IErrorResponse<DeviceUploadError>
{
    public static DeviceUploadErrorResponse Instance { get; } = new();

    private DeviceUploadErrorResponse()
    {
    }

    public Task<DeviceUploadError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeviceUploadError.Create(response, ct);
}
