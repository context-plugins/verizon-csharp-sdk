using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountLicensesStatusError : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private GetAccountLicensesStatusError(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static GetAccountLicensesStatusError AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static GetAccountLicensesStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<GetAccountLicensesStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountLicensesStatusErrorResponse : IErrorResponse<GetAccountLicensesStatusError>
{
    public static GetAccountLicensesStatusErrorResponse Instance { get; } = new();

    private GetAccountLicensesStatusErrorResponse()
    {
    }

    public Task<GetAccountLicensesStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountLicensesStatusError.Create(response, ct);
}
