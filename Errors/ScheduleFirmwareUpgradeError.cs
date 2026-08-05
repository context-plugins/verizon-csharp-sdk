using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ScheduleFirmwareUpgradeError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private ScheduleFirmwareUpgradeError(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static ScheduleFirmwareUpgradeError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static ScheduleFirmwareUpgradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<ScheduleFirmwareUpgradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ScheduleFirmwareUpgradeErrorResponse : IErrorResponse<ScheduleFirmwareUpgradeError>
{
    public static ScheduleFirmwareUpgradeErrorResponse Instance { get; } = new();

    private ScheduleFirmwareUpgradeErrorResponse()
    {
    }

    public Task<ScheduleFirmwareUpgradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ScheduleFirmwareUpgradeError.Create(response, ct);
}
