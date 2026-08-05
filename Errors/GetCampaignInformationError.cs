using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetCampaignInformationError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private GetCampaignInformationError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static GetCampaignInformationError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static GetCampaignInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<GetCampaignInformationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCampaignInformationErrorResponse : IErrorResponse<GetCampaignInformationError>
{
    public static GetCampaignInformationErrorResponse Instance { get; } = new();

    private GetCampaignInformationErrorResponse()
    {
    }

    public Task<GetCampaignInformationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCampaignInformationError.Create(response, ct);
}
