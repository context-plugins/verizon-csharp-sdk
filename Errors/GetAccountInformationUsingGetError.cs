using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountInformationUsingGetError : ApiError
{
    private readonly Optional<RestErrorResponseforplanner> _restErrorResponseforplannerValue;

    private readonly Optional<AuthRestErrorResponseforplanner> _authRestErrorResponseforplannerValue;

    private GetAccountInformationUsingGetError(Optional<RestErrorResponseforplanner> restErrorResponseforplannerValue,
        Optional<AuthRestErrorResponseforplanner> authRestErrorResponseforplannerValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseforplannerValue = restErrorResponseforplannerValue;
        _authRestErrorResponseforplannerValue = authRestErrorResponseforplannerValue;
    }

    private static GetAccountInformationUsingGetError AsRestErrorResponseforplanner(RestErrorResponseforplanner value) =>
        new(Optional<RestErrorResponseforplanner>.Some(value), default, default);

    private static GetAccountInformationUsingGetError AsAuthRestErrorResponseforplanner(AuthRestErrorResponseforplanner value) =>
        new(default, Optional<AuthRestErrorResponseforplanner>.Some(value), default);

    private static GetAccountInformationUsingGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner value) =>
        _restErrorResponseforplannerValue.TryGetValue(out value);

    public bool TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner value) =>
        _authRestErrorResponseforplannerValue.TryGetValue(out value);

    internal static Task<GetAccountInformationUsingGetError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 406 or 429 => FromJson<RestErrorResponseforplanner>(response, ct).As(AsRestErrorResponseforplanner),
            401 => FromJson<AuthRestErrorResponseforplanner>(response, ct).As(AsAuthRestErrorResponseforplanner),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountInformationUsingGetErrorResponse : IErrorResponse<GetAccountInformationUsingGetError>
{
    public static GetAccountInformationUsingGetErrorResponse Instance { get; } = new();

    private GetAccountInformationUsingGetErrorResponse()
    {
    }

    public Task<GetAccountInformationUsingGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountInformationUsingGetError.Create(response, ct);
}
