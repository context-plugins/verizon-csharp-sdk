using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SetConnectionPlannerError : ApiError
{
    private readonly Optional<RestErrorResponseforplanner> _restErrorResponseforplannerValue;

    private readonly Optional<AuthRestErrorResponseforplanner> _authRestErrorResponseforplannerValue;

    private SetConnectionPlannerError(Optional<RestErrorResponseforplanner> restErrorResponseforplannerValue,
        Optional<AuthRestErrorResponseforplanner> authRestErrorResponseforplannerValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restErrorResponseforplannerValue = restErrorResponseforplannerValue;
        _authRestErrorResponseforplannerValue = authRestErrorResponseforplannerValue;
    }

    private static SetConnectionPlannerError AsRestErrorResponseforplanner(RestErrorResponseforplanner value) =>
        new(Optional<RestErrorResponseforplanner>.Some(value), default, default);

    private static SetConnectionPlannerError AsAuthRestErrorResponseforplanner(AuthRestErrorResponseforplanner value) =>
        new(default, Optional<AuthRestErrorResponseforplanner>.Some(value), default);

    private static SetConnectionPlannerError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner value) =>
        _restErrorResponseforplannerValue.TryGetValue(out value);

    public bool TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner value) =>
        _authRestErrorResponseforplannerValue.TryGetValue(out value);

    internal static Task<SetConnectionPlannerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 406 or 429 => FromJson<RestErrorResponseforplanner>(response, ct).As(AsRestErrorResponseforplanner),
            401 => FromJson<AuthRestErrorResponseforplanner>(response, ct).As(AsAuthRestErrorResponseforplanner),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetConnectionPlannerErrorResponse : IErrorResponse<SetConnectionPlannerError>
{
    public static SetConnectionPlannerErrorResponse Instance { get; } = new();

    private SetConnectionPlannerErrorResponse()
    {
    }

    public Task<SetConnectionPlannerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetConnectionPlannerError.Create(response, ct);
}
