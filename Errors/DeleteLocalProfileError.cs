using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteLocalProfileError : ApiError
{
    private readonly Optional<RestErrorResponse> _restErrorResponseValue;

    private DeleteLocalProfileError(Optional<RestErrorResponse> restErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseValue = restErrorResponseValue;
    }

    private static DeleteLocalProfileError AsRestErrorResponse(RestErrorResponse value) =>
        new(Optional<RestErrorResponse>.Some(value), default);

    private static DeleteLocalProfileError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponse(out RestErrorResponse value) =>
        _restErrorResponseValue.TryGetValue(out value);

    internal static Task<DeleteLocalProfileError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<RestErrorResponse>(response, ct).As(AsRestErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLocalProfileErrorResponse : IErrorResponse<DeleteLocalProfileError>
{
    public static DeleteLocalProfileErrorResponse Instance { get; } = new();

    private DeleteLocalProfileErrorResponse()
    {
    }

    public Task<DeleteLocalProfileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLocalProfileError.Create(response, ct);
}
