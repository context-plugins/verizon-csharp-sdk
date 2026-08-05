using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CancelManagedAccountActionError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private CancelManagedAccountActionError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static CancelManagedAccountActionError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static CancelManagedAccountActionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<CancelManagedAccountActionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelManagedAccountActionErrorResponse : IErrorResponse<CancelManagedAccountActionError>
{
    public static CancelManagedAccountActionErrorResponse Instance { get; } = new();

    private CancelManagedAccountActionErrorResponse()
    {
    }

    public Task<CancelManagedAccountActionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelManagedAccountActionError.Create(response, ct);
}
