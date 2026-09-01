using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class StartQueuedSmsDeliveryError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private StartQueuedSmsDeliveryError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static StartQueuedSmsDeliveryError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static StartQueuedSmsDeliveryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<StartQueuedSmsDeliveryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class StartQueuedSmsDeliveryErrorResponse : IErrorResponse<StartQueuedSmsDeliveryError>
{
    public static StartQueuedSmsDeliveryErrorResponse Instance { get; } = new();

    private StartQueuedSmsDeliveryErrorResponse()
    {
    }

    public Task<StartQueuedSmsDeliveryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        StartQueuedSmsDeliveryError.Create(response, ct);
}
