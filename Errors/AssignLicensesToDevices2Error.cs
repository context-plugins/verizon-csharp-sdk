using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class AssignLicensesToDevices2Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private AssignLicensesToDevices2Error(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static AssignLicensesToDevices2Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static AssignLicensesToDevices2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<AssignLicensesToDevices2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AssignLicensesToDevices2ErrorResponse : IErrorResponse<AssignLicensesToDevices2Error>
{
    public static AssignLicensesToDevices2ErrorResponse Instance { get; } = new();

    private AssignLicensesToDevices2ErrorResponse()
    {
    }

    public Task<AssignLicensesToDevices2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AssignLicensesToDevices2Error.Create(response, ct);
}
