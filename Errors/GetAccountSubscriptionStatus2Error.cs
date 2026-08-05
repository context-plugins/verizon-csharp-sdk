using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountSubscriptionStatus2Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private GetAccountSubscriptionStatus2Error(Optional<FotaV2Result> fotaV2ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static GetAccountSubscriptionStatus2Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static GetAccountSubscriptionStatus2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<GetAccountSubscriptionStatus2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountSubscriptionStatus2ErrorResponse : IErrorResponse<GetAccountSubscriptionStatus2Error>
{
    public static GetAccountSubscriptionStatus2ErrorResponse Instance { get; } = new();

    private GetAccountSubscriptionStatus2ErrorResponse()
    {
    }

    public Task<GetAccountSubscriptionStatus2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountSubscriptionStatus2Error.Create(response, ct);
}
