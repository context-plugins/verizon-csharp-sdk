using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ScheduleSwupgradeHttpDevicesError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private ScheduleSwupgradeHttpDevicesError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static ScheduleSwupgradeHttpDevicesError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static ScheduleSwupgradeHttpDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<ScheduleSwupgradeHttpDevicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ScheduleSwupgradeHttpDevicesErrorResponse : IErrorResponse<ScheduleSwupgradeHttpDevicesError>
{
    public static ScheduleSwupgradeHttpDevicesErrorResponse Instance { get; } = new();

    private ScheduleSwupgradeHttpDevicesErrorResponse()
    {
    }

    public Task<ScheduleSwupgradeHttpDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ScheduleSwupgradeHttpDevicesError.Create(response, ct);
}
