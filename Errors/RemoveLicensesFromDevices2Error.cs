using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RemoveLicensesFromDevices2Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private RemoveLicensesFromDevices2Error(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static RemoveLicensesFromDevices2Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static RemoveLicensesFromDevices2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<RemoveLicensesFromDevices2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveLicensesFromDevices2ErrorResponse : IErrorResponse<RemoveLicensesFromDevices2Error>
{
    public static RemoveLicensesFromDevices2ErrorResponse Instance { get; } = new();

    private RemoveLicensesFromDevices2ErrorResponse()
    {
    }

    public Task<RemoveLicensesFromDevices2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveLicensesFromDevices2Error.Create(response, ct);
}
