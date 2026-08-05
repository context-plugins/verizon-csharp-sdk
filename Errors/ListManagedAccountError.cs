using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListManagedAccountError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private ListManagedAccountError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static ListManagedAccountError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static ListManagedAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<ListManagedAccountError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListManagedAccountErrorResponse : IErrorResponse<ListManagedAccountError>
{
    public static ListManagedAccountErrorResponse Instance { get; } = new();

    private ListManagedAccountErrorResponse()
    {
    }

    public Task<ListManagedAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListManagedAccountError.Create(response, ct);
}
