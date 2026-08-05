using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class AssignLicensesToDevices3Error : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private AssignLicensesToDevices3Error(Optional<FotaV3Result> fotaV3ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static AssignLicensesToDevices3Error AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static AssignLicensesToDevices3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<AssignLicensesToDevices3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AssignLicensesToDevices3ErrorResponse : IErrorResponse<AssignLicensesToDevices3Error>
{
    public static AssignLicensesToDevices3ErrorResponse Instance { get; } = new();

    private AssignLicensesToDevices3ErrorResponse()
    {
    }

    public Task<AssignLicensesToDevices3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AssignLicensesToDevices3Error.Create(response, ct);
}
