using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetLocationServiceSubscriptionStatusError : ApiError
{
    private readonly Optional<DeviceLocationResult> _deviceLocationResultValue;

    private GetLocationServiceSubscriptionStatusError(Optional<DeviceLocationResult> deviceLocationResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceLocationResultValue = deviceLocationResultValue;
    }

    private static GetLocationServiceSubscriptionStatusError AsDeviceLocationResult(DeviceLocationResult value) =>
        new(Optional<DeviceLocationResult>.Some(value), default);

    private static GetLocationServiceSubscriptionStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceLocationResult(out DeviceLocationResult value) =>
        _deviceLocationResultValue.TryGetValue(out value);

    internal static Task<GetLocationServiceSubscriptionStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceLocationResult>(response, ct).As(AsDeviceLocationResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLocationServiceSubscriptionStatusErrorResponse : IErrorResponse<GetLocationServiceSubscriptionStatusError>
{
    public static GetLocationServiceSubscriptionStatusErrorResponse Instance { get; } = new();

    private GetLocationServiceSubscriptionStatusErrorResponse()
    {
    }

    public Task<GetLocationServiceSubscriptionStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLocationServiceSubscriptionStatusError.Create(response, ct);
}
