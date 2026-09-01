using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ScheduleSwUpgradeHttpDevicesError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private ScheduleSwUpgradeHttpDevicesError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static ScheduleSwUpgradeHttpDevicesError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static ScheduleSwUpgradeHttpDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<ScheduleSwUpgradeHttpDevicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ScheduleSwUpgradeHttpDevicesErrorResponse : IErrorResponse<ScheduleSwUpgradeHttpDevicesError>
{
    public static ScheduleSwUpgradeHttpDevicesErrorResponse Instance { get; } = new();

    private ScheduleSwUpgradeHttpDevicesErrorResponse()
    {
    }

    public Task<ScheduleSwUpgradeHttpDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ScheduleSwUpgradeHttpDevicesError.Create(response, ct);
}
