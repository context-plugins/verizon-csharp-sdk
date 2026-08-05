using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GenerateCredentialsError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private GenerateCredentialsError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static GenerateCredentialsError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static GenerateCredentialsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<GenerateCredentialsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GenerateCredentialsErrorResponse : IErrorResponse<GenerateCredentialsError>
{
    public static GenerateCredentialsErrorResponse Instance { get; } = new();

    private GenerateCredentialsErrorResponse()
    {
    }

    public Task<GenerateCredentialsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GenerateCredentialsError.Create(response, ct);
}
