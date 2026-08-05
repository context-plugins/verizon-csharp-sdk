using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAccountSubscriptionsError : ApiError
{
    private readonly Optional<SecurityResult> _securityResultValue;

    private ListAccountSubscriptionsError(Optional<SecurityResult> securityResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _securityResultValue = securityResultValue;
    }

    private static ListAccountSubscriptionsError AsSecurityResult(SecurityResult value) =>
        new(Optional<SecurityResult>.Some(value), default);

    private static ListAccountSubscriptionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetSecurityResult(out SecurityResult value) => _securityResultValue.TryGetValue(out value);

    internal static Task<ListAccountSubscriptionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<SecurityResult>(response, ct).As(AsSecurityResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAccountSubscriptionsErrorResponse : IErrorResponse<ListAccountSubscriptionsError>
{
    public static ListAccountSubscriptionsErrorResponse Instance { get; } = new();

    private ListAccountSubscriptionsErrorResponse()
    {
    }

    public Task<ListAccountSubscriptionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAccountSubscriptionsError.Create(response, ct);
}
