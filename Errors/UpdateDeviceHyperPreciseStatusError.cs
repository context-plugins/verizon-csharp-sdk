using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateDeviceHyperPreciseStatusError : ApiError
{
    private readonly Optional<HyperPreciseLocationResult> _hyperPreciseLocationResultValue;

    private UpdateDeviceHyperPreciseStatusError(Optional<HyperPreciseLocationResult> hyperPreciseLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _hyperPreciseLocationResultValue = hyperPreciseLocationResultValue;
    }

    private static UpdateDeviceHyperPreciseStatusError AsHyperPreciseLocationResult(HyperPreciseLocationResult value) =>
        new(Optional<HyperPreciseLocationResult>.Some(value), default);

    private static UpdateDeviceHyperPreciseStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetHyperPreciseLocationResult(out HyperPreciseLocationResult value) =>
        _hyperPreciseLocationResultValue.TryGetValue(out value);

    internal static Task<UpdateDeviceHyperPreciseStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 409 or 500 => FromJson<HyperPreciseLocationResult>(response, ct).As(AsHyperPreciseLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateDeviceHyperPreciseStatusErrorResponse : IErrorResponse<UpdateDeviceHyperPreciseStatusError>
{
    public static UpdateDeviceHyperPreciseStatusErrorResponse Instance { get; } = new();

    private UpdateDeviceHyperPreciseStatusErrorResponse()
    {
    }

    public Task<UpdateDeviceHyperPreciseStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateDeviceHyperPreciseStatusError.Create(response, ct);
}
