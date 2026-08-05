using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateConfigurationError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private UpdateConfigurationError(Optional<ResponseError> responseErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static UpdateConfigurationError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static UpdateConfigurationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    internal static Task<UpdateConfigurationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 429 => FromJson<ResponseError>(response, ct).As(AsResponseError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateConfigurationErrorResponse : IErrorResponse<UpdateConfigurationError>
{
    public static UpdateConfigurationErrorResponse Instance { get; } = new();

    private UpdateConfigurationErrorResponse()
    {
    }

    public Task<UpdateConfigurationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateConfigurationError.Create(response, ct);
}
