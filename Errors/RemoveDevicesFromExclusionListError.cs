using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RemoveDevicesFromExclusionListError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private RemoveDevicesFromExclusionListError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static RemoveDevicesFromExclusionListError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static RemoveDevicesFromExclusionListError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<RemoveDevicesFromExclusionListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveDevicesFromExclusionListErrorResponse : IErrorResponse<RemoveDevicesFromExclusionListError>
{
    public static RemoveDevicesFromExclusionListErrorResponse Instance { get; } = new();

    private RemoveDevicesFromExclusionListErrorResponse()
    {
    }

    public Task<RemoveDevicesFromExclusionListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveDevicesFromExclusionListError.Create(response, ct);
}
