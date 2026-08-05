using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetCampaignHistoryByStatus2Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetCampaignHistoryByStatus2Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetCampaignHistoryByStatus2Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetCampaignHistoryByStatus2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<GetCampaignHistoryByStatus2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCampaignHistoryByStatus2ErrorResponse : IErrorResponse<GetCampaignHistoryByStatus2Error>
{
    public static GetCampaignHistoryByStatus2ErrorResponse Instance { get; } = new();

    private GetCampaignHistoryByStatus2ErrorResponse()
    {
    }

    public Task<GetCampaignHistoryByStatus2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCampaignHistoryByStatus2Error.Create(response, ct);
}
