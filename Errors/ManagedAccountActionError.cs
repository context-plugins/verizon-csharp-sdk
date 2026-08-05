using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ManagedAccountActionError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private ManagedAccountActionError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static ManagedAccountActionError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static ManagedAccountActionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<ManagedAccountActionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ManagedAccountActionErrorResponse : IErrorResponse<ManagedAccountActionError>
{
    public static ManagedAccountActionErrorResponse Instance { get; } = new();

    private ManagedAccountActionErrorResponse()
    {
    }

    public Task<ManagedAccountActionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ManagedAccountActionError.Create(response, ct);
}
