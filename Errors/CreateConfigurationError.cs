using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CreateConfigurationError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private CreateConfigurationError(Optional<ResponseError> responseErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static CreateConfigurationError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static CreateConfigurationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    internal static Task<CreateConfigurationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 429 => FromJson<ResponseError>(response, ct).As(AsResponseError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateConfigurationErrorResponse : IErrorResponse<CreateConfigurationError>
{
    public static CreateConfigurationErrorResponse Instance { get; } = new();

    private CreateConfigurationErrorResponse()
    {
    }

    public Task<CreateConfigurationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateConfigurationError.Create(response, ct);
}
