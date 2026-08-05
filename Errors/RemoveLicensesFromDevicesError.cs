using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RemoveLicensesFromDevicesError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private RemoveLicensesFromDevicesError(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static RemoveLicensesFromDevicesError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static RemoveLicensesFromDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<RemoveLicensesFromDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveLicensesFromDevicesErrorResponse : IErrorResponse<RemoveLicensesFromDevicesError>
{
    public static RemoveLicensesFromDevicesErrorResponse Instance { get; } = new();

    private RemoveLicensesFromDevicesErrorResponse()
    {
    }

    public Task<RemoveLicensesFromDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveLicensesFromDevicesError.Create(response, ct);
}
