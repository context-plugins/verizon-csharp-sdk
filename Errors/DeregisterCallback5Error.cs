using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeregisterCallback5Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private DeregisterCallback5Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static DeregisterCallback5Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static DeregisterCallback5Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<DeregisterCallback5Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeregisterCallback5ErrorResponse : IErrorResponse<DeregisterCallback5Error>
{
    public static DeregisterCallback5ErrorResponse Instance { get; } = new();

    private DeregisterCallback5ErrorResponse()
    {
    }

    public Task<DeregisterCallback5Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeregisterCallback5Error.Create(response, ct);
}
