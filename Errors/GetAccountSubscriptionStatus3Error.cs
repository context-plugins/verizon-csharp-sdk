using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountSubscriptionStatus3Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetAccountSubscriptionStatus3Error(Optional<FotaV3Result> fotaV3ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetAccountSubscriptionStatus3Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetAccountSubscriptionStatus3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<GetAccountSubscriptionStatus3Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountSubscriptionStatus3ErrorResponse : IErrorResponse<GetAccountSubscriptionStatus3Error>
{
    public static GetAccountSubscriptionStatus3ErrorResponse Instance { get; } = new();

    private GetAccountSubscriptionStatus3ErrorResponse()
    {
    }

    public Task<GetAccountSubscriptionStatus3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountSubscriptionStatus3Error.Create(response, ct);
}
