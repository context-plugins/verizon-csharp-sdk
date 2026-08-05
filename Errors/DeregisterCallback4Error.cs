using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeregisterCallback4Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private DeregisterCallback4Error(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static DeregisterCallback4Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static DeregisterCallback4Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<DeregisterCallback4Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeregisterCallback4ErrorResponse : IErrorResponse<DeregisterCallback4Error>
{
    public static DeregisterCallback4ErrorResponse Instance { get; } = new();

    private DeregisterCallback4ErrorResponse()
    {
    }

    public Task<DeregisterCallback4Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeregisterCallback4Error.Create(response, ct);
}
