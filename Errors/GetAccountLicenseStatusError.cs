using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountLicenseStatusError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private GetAccountLicenseStatusError(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static GetAccountLicenseStatusError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static GetAccountLicenseStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<GetAccountLicenseStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountLicenseStatusErrorResponse : IErrorResponse<GetAccountLicenseStatusError>
{
    public static GetAccountLicenseStatusErrorResponse Instance { get; } = new();

    private GetAccountLicenseStatusErrorResponse()
    {
    }

    public Task<GetAccountLicenseStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountLicenseStatusError.Create(response, ct);
}
