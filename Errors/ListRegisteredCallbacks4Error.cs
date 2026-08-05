using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListRegisteredCallbacks4Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private ListRegisteredCallbacks4Error(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static ListRegisteredCallbacks4Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static ListRegisteredCallbacks4Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<ListRegisteredCallbacks4Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListRegisteredCallbacks4ErrorResponse : IErrorResponse<ListRegisteredCallbacks4Error>
{
    public static ListRegisteredCallbacks4ErrorResponse Instance { get; } = new();

    private ListRegisteredCallbacks4ErrorResponse()
    {
    }

    public Task<ListRegisteredCallbacks4Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListRegisteredCallbacks4Error.Create(response, ct);
}
