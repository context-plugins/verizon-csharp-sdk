using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CreateNewTriggerError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private CreateNewTriggerError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static CreateNewTriggerError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static CreateNewTriggerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<CreateNewTriggerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateNewTriggerErrorResponse : IErrorResponse<CreateNewTriggerError>
{
    public static CreateNewTriggerErrorResponse Instance { get; } = new();

    private CreateNewTriggerErrorResponse()
    {
    }

    public Task<CreateNewTriggerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateNewTriggerError.Create(response, ct);
}
