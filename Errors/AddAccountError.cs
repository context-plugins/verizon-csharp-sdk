using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class AddAccountError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private AddAccountError(Optional<DeviceLocationResult> deviceLocationResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static AddAccountError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static AddAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<AddAccountError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddAccountErrorResponse : IErrorResponse<AddAccountError>
{
    public static AddAccountErrorResponse Instance { get; } = new();

    private AddAccountErrorResponse()
    {
    }

    public Task<AddAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddAccountError.Create(response, ct);
}
