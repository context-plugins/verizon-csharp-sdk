using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeregisterCallback6Error : ApiError
{
    private readonly Optional<HyperPreciseLocationResult> _hyperPreciseLocationResultValue;

    private DeregisterCallback6Error(Optional<HyperPreciseLocationResult> hyperPreciseLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _hyperPreciseLocationResultValue = hyperPreciseLocationResultValue;
    }

    private static DeregisterCallback6Error AsHyperPreciseLocationResult(HyperPreciseLocationResult value) =>
        new(Optional<HyperPreciseLocationResult>.Some(value), default);

    private static DeregisterCallback6Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult value) =>
        _hyperPreciseLocationResultValue.TryGetValue(out value);

    internal static Task<DeregisterCallback6Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 409 or 500 => FromJson<HyperPreciseLocationResult>(response, ct).As(AsHyperPreciseLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeregisterCallback6ErrorResponse : IErrorResponse<DeregisterCallback6Error>
{
    public static DeregisterCallback6ErrorResponse Instance { get; } = new();

    private DeregisterCallback6ErrorResponse()
    {
    }

    public Task<DeregisterCallback6Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeregisterCallback6Error.Create(response, ct);
}
