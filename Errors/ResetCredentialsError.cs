using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ResetCredentialsError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private ResetCredentialsError(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static ResetCredentialsError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static ResetCredentialsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<ResetCredentialsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ResetCredentialsErrorResponse : IErrorResponse<ResetCredentialsError>
{
    public static ResetCredentialsErrorResponse Instance { get; } = new();

    private ResetCredentialsErrorResponse()
    {
    }

    public Task<ResetCredentialsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ResetCredentialsError.Create(response, ct);
}
