using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RegisterCallback2Error : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private RegisterCallback2Error(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static RegisterCallback2Error AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static RegisterCallback2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<RegisterCallback2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RegisterCallback2ErrorResponse : IErrorResponse<RegisterCallback2Error>
{
    public static RegisterCallback2ErrorResponse Instance { get; } = new();

    private RegisterCallback2ErrorResponse()
    {
    }

    public Task<RegisterCallback2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RegisterCallback2Error.Create(response, ct);
}
