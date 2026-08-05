using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAccountDevicesInformationError : ApiError
{
    private readonly Optional<FotaV3Result> _fotaV3ResultValue;

    private ListAccountDevicesInformationError(Optional<FotaV3Result> fotaV3ResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fotaV3ResultValue = fotaV3ResultValue;
    }

    private static ListAccountDevicesInformationError AsFotaV3Result(FotaV3Result value) =>
        new(Optional<FotaV3Result>.Some(value), default);

    private static ListAccountDevicesInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV3Result(out FotaV3Result value) => _fotaV3ResultValue.TryGetValue(out value);

    internal static Task<ListAccountDevicesInformationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV3Result>(response, ct).As(AsFotaV3Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAccountDevicesInformationErrorResponse : IErrorResponse<ListAccountDevicesInformationError>
{
    public static ListAccountDevicesInformationErrorResponse Instance { get; } = new();

    private ListAccountDevicesInformationErrorResponse()
    {
    }

    public Task<ListAccountDevicesInformationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAccountDevicesInformationError.Create(response, ct);
}
