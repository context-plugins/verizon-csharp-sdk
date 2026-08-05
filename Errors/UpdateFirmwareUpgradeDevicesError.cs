using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateFirmwareUpgradeDevicesError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private UpdateFirmwareUpgradeDevicesError(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static UpdateFirmwareUpgradeDevicesError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static UpdateFirmwareUpgradeDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<UpdateFirmwareUpgradeDevicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateFirmwareUpgradeDevicesErrorResponse : IErrorResponse<UpdateFirmwareUpgradeDevicesError>
{
    public static UpdateFirmwareUpgradeDevicesErrorResponse Instance { get; } = new();

    private UpdateFirmwareUpgradeDevicesErrorResponse()
    {
    }

    public Task<UpdateFirmwareUpgradeDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateFirmwareUpgradeDevicesError.Create(response, ct);
}
