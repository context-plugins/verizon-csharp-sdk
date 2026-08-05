using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteTriggerError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private DeleteTriggerError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static DeleteTriggerError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static DeleteTriggerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<DeleteTriggerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteTriggerErrorResponse : IErrorResponse<DeleteTriggerError>
{
    public static DeleteTriggerErrorResponse Instance { get; } = new();

    private DeleteTriggerErrorResponse()
    {
    }

    public Task<DeleteTriggerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteTriggerError.Create(response, ct);
}
