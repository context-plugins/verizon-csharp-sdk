using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetCampaignDeviceStatus2Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetCampaignDeviceStatus2Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetCampaignDeviceStatus2Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetCampaignDeviceStatus2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<GetCampaignDeviceStatus2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCampaignDeviceStatus2ErrorResponse : IErrorResponse<GetCampaignDeviceStatus2Error>
{
    public static GetCampaignDeviceStatus2ErrorResponse Instance { get; } = new();

    private GetCampaignDeviceStatus2ErrorResponse()
    {
    }

    public Task<GetCampaignDeviceStatus2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCampaignDeviceStatus2Error.Create(response, ct);
}
