using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateTriggerError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private UpdateTriggerError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static UpdateTriggerError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static UpdateTriggerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<UpdateTriggerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateTriggerErrorResponse : IErrorResponse<UpdateTriggerError>
{
    public static UpdateTriggerErrorResponse Instance { get; } = new();

    private UpdateTriggerErrorResponse()
    {
    }

    public Task<UpdateTriggerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateTriggerError.Create(response, ct);
}
