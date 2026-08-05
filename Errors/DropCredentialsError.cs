using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DropCredentialsError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private DropCredentialsError(Optional<ErrorResponseModel> errorResponseModelValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static DropCredentialsError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static DropCredentialsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    internal static Task<DropCredentialsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ErrorResponseModel>(response, ct).As(AsErrorResponseModel),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DropCredentialsErrorResponse : IErrorResponse<DropCredentialsError>
{
    public static DropCredentialsErrorResponse Instance { get; } = new();

    private DropCredentialsErrorResponse()
    {
    }

    public Task<DropCredentialsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DropCredentialsError.Create(response, ct);
}
