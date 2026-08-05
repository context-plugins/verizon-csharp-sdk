using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ProfileToSetFallbackAttributeError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private ProfileToSetFallbackAttributeError(Optional<RestErrorResponse> restErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static ProfileToSetFallbackAttributeError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static ProfileToSetFallbackAttributeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<ProfileToSetFallbackAttributeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ProfileToSetFallbackAttributeErrorResponse : IErrorResponse<ProfileToSetFallbackAttributeError>
{
    public static ProfileToSetFallbackAttributeErrorResponse Instance { get; } = new();

    private ProfileToSetFallbackAttributeErrorResponse()
    {
    }

    public Task<ProfileToSetFallbackAttributeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ProfileToSetFallbackAttributeError.Create(response, ct);
}
