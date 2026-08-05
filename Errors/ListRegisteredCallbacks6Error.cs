using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListRegisteredCallbacks6Error : ApiError
{
    private readonly Optional<HyperPreciseLocationResult> _hyperPreciseLocationResultValue;

    private ListRegisteredCallbacks6Error(Optional<HyperPreciseLocationResult> hyperPreciseLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _hyperPreciseLocationResultValue = hyperPreciseLocationResultValue;
    }

    private static ListRegisteredCallbacks6Error AsHyperPreciseLocationResult(HyperPreciseLocationResult value) =>
        new(Optional<HyperPreciseLocationResult>.Some(value), default);

    private static ListRegisteredCallbacks6Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult value) =>
        _hyperPreciseLocationResultValue.TryGetValue(out value);

    internal static Task<ListRegisteredCallbacks6Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 409 or 500 => FromJson<HyperPreciseLocationResult>(response, ct).As(AsHyperPreciseLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListRegisteredCallbacks6ErrorResponse : IErrorResponse<ListRegisteredCallbacks6Error>
{
    public static ListRegisteredCallbacks6ErrorResponse Instance { get; } = new();

    private ListRegisteredCallbacks6ErrorResponse()
    {
    }

    public Task<ListRegisteredCallbacks6Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListRegisteredCallbacks6Error.Create(response, ct);
}
