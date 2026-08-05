using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListRegisteredCallbacks2Error : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private ListRegisteredCallbacks2Error(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static ListRegisteredCallbacks2Error AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static ListRegisteredCallbacks2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<ListRegisteredCallbacks2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListRegisteredCallbacks2ErrorResponse : IErrorResponse<ListRegisteredCallbacks2Error>
{
    public static ListRegisteredCallbacks2ErrorResponse Instance { get; } = new();

    private ListRegisteredCallbacks2ErrorResponse()
    {
    }

    public Task<ListRegisteredCallbacks2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListRegisteredCallbacks2Error.Create(response, ct);
}
