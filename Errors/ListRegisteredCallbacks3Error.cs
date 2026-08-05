using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListRegisteredCallbacks3Error : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private ListRegisteredCallbacks3Error(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static ListRegisteredCallbacks3Error AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static ListRegisteredCallbacks3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<ListRegisteredCallbacks3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListRegisteredCallbacks3ErrorResponse : IErrorResponse<ListRegisteredCallbacks3Error>
{
    public static ListRegisteredCallbacks3ErrorResponse Instance { get; } = new();

    private ListRegisteredCallbacks3ErrorResponse()
    {
    }

    public Task<ListRegisteredCallbacks3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListRegisteredCallbacks3Error.Create(response, ct);
}
