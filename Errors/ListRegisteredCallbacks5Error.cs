using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListRegisteredCallbacks5Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private ListRegisteredCallbacks5Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static ListRegisteredCallbacks5Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static ListRegisteredCallbacks5Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<ListRegisteredCallbacks5Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListRegisteredCallbacks5ErrorResponse : IErrorResponse<ListRegisteredCallbacks5Error>
{
    public static ListRegisteredCallbacks5ErrorResponse Instance { get; } = new();

    private ListRegisteredCallbacks5ErrorResponse()
    {
    }

    public Task<ListRegisteredCallbacks5Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListRegisteredCallbacks5Error.Create(response, ct);
}
