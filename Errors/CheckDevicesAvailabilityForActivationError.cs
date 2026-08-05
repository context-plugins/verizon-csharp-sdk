using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class CheckDevicesAvailabilityForActivationError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private CheckDevicesAvailabilityForActivationError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static CheckDevicesAvailabilityForActivationError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static CheckDevicesAvailabilityForActivationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<CheckDevicesAvailabilityForActivationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckDevicesAvailabilityForActivationErrorResponse : IErrorResponse<CheckDevicesAvailabilityForActivationError>
{
    public static CheckDevicesAvailabilityForActivationErrorResponse Instance { get; } = new();

    private CheckDevicesAvailabilityForActivationErrorResponse()
    {
    }

    public Task<CheckDevicesAvailabilityForActivationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckDevicesAvailabilityForActivationError.Create(response, ct);
}
