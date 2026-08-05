using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeregisterCallback2Error : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private DeregisterCallback2Error(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static DeregisterCallback2Error AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static DeregisterCallback2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<DeregisterCallback2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeregisterCallback2ErrorResponse : IErrorResponse<DeregisterCallback2Error>
{
    public static DeregisterCallback2ErrorResponse Instance { get; } = new();

    private DeregisterCallback2ErrorResponse()
    {
    }

    public Task<DeregisterCallback2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeregisterCallback2Error.Create(response, ct);
}
