using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetDeviceCheckInHistoryError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private GetDeviceCheckInHistoryError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static GetDeviceCheckInHistoryError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static GetDeviceCheckInHistoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<GetDeviceCheckInHistoryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDeviceCheckInHistoryErrorResponse : IErrorResponse<GetDeviceCheckInHistoryError>
{
    public static GetDeviceCheckInHistoryErrorResponse Instance { get; } = new();

    private GetDeviceCheckInHistoryErrorResponse()
    {
    }

    public Task<GetDeviceCheckInHistoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDeviceCheckInHistoryError.Create(response, ct);
}
