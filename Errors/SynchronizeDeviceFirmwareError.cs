using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SynchronizeDeviceFirmwareError : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private SynchronizeDeviceFirmwareError(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static SynchronizeDeviceFirmwareError AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static SynchronizeDeviceFirmwareError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<SynchronizeDeviceFirmwareError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SynchronizeDeviceFirmwareErrorResponse : IErrorResponse<SynchronizeDeviceFirmwareError>
{
    public static SynchronizeDeviceFirmwareErrorResponse Instance { get; } = new();

    private SynchronizeDeviceFirmwareErrorResponse()
    {
    }

    public Task<SynchronizeDeviceFirmwareError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SynchronizeDeviceFirmwareError.Create(response, ct);
}
