using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAvailableSoftwareError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private ListAvailableSoftwareError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static ListAvailableSoftwareError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static ListAvailableSoftwareError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<ListAvailableSoftwareError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAvailableSoftwareErrorResponse : IErrorResponse<ListAvailableSoftwareError>
{
    public static ListAvailableSoftwareErrorResponse Instance { get; } = new();

    private ListAvailableSoftwareErrorResponse()
    {
    }

    public Task<ListAvailableSoftwareError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAvailableSoftwareError.Create(response, ct);
}
