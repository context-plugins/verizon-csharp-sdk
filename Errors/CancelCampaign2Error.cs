using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CancelCampaign2Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private CancelCampaign2Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static CancelCampaign2Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static CancelCampaign2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<CancelCampaign2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelCampaign2ErrorResponse : IErrorResponse<CancelCampaign2Error>
{
    public static CancelCampaign2ErrorResponse Instance { get; } = new();

    private CancelCampaign2ErrorResponse()
    {
    }

    public Task<CancelCampaign2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelCampaign2Error.Create(response, ct);
}
