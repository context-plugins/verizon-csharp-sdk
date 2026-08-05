using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteConfigurationError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private DeleteConfigurationError(Optional<ResponseError> responseErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static DeleteConfigurationError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static DeleteConfigurationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    internal static Task<DeleteConfigurationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 429 => FromJson<ResponseError>(response, ct).As(AsResponseError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteConfigurationErrorResponse : IErrorResponse<DeleteConfigurationError>
{
    public static DeleteConfigurationErrorResponse Instance { get; } = new();

    private DeleteConfigurationErrorResponse()
    {
    }

    public Task<DeleteConfigurationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteConfigurationError.Create(response, ct);
}
