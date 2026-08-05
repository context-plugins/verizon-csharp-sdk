using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RemoveLicensesFromDevices3Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private RemoveLicensesFromDevices3Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static RemoveLicensesFromDevices3Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static RemoveLicensesFromDevices3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<RemoveLicensesFromDevices3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveLicensesFromDevices3ErrorResponse : IErrorResponse<RemoveLicensesFromDevices3Error>
{
    public static RemoveLicensesFromDevices3ErrorResponse Instance { get; } = new();

    private RemoveLicensesFromDevices3ErrorResponse()
    {
    }

    public Task<RemoveLicensesFromDevices3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveLicensesFromDevices3Error.Create(response, ct);
}
