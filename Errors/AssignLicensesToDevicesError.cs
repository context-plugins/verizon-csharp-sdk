using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class AssignLicensesToDevicesError : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private AssignLicensesToDevicesError(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static AssignLicensesToDevicesError AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static AssignLicensesToDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<AssignLicensesToDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AssignLicensesToDevicesErrorResponse : IErrorResponse<AssignLicensesToDevicesError>
{
    public static AssignLicensesToDevicesErrorResponse Instance { get; } = new();

    private AssignLicensesToDevicesErrorResponse()
    {
    }

    public Task<AssignLicensesToDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AssignLicensesToDevicesError.Create(response, ct);
}
