using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetConfigurationListError : ApiError
{
    private readonly Optional<ResponseError> _responseErrorValue;

    private GetConfigurationListError(Optional<ResponseError> responseErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _responseErrorValue = responseErrorValue;
    }

    private static GetConfigurationListError AsResponseError(ResponseError value) =>
        new(Optional<ResponseError>.Some(value), default);

    private static GetConfigurationListError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetResponseError(out ResponseError value) => _responseErrorValue.TryGetValue(out value);

    internal static Task<GetConfigurationListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 or 429 => FromJson<ResponseError>(response, ct).As(AsResponseError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetConfigurationListErrorResponse : IErrorResponse<GetConfigurationListError>
{
    public static GetConfigurationListErrorResponse Instance { get; } = new();

    private GetConfigurationListErrorResponse()
    {
    }

    public Task<GetConfigurationListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetConfigurationListError.Create(response, ct);
}
