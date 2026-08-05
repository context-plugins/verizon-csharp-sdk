using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListExcludedDevicesError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private ListExcludedDevicesError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static ListExcludedDevicesError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static ListExcludedDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<ListExcludedDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListExcludedDevicesErrorResponse : IErrorResponse<ListExcludedDevicesError>
{
    public static ListExcludedDevicesErrorResponse Instance { get; } = new();

    private ListExcludedDevicesErrorResponse()
    {
    }

    public Task<ListExcludedDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListExcludedDevicesError.Create(response, ct);
}
