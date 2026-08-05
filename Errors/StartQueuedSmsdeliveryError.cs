using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class StartQueuedSmsdeliveryError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private StartQueuedSmsdeliveryError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static StartQueuedSmsdeliveryError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static StartQueuedSmsdeliveryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<StartQueuedSmsdeliveryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class StartQueuedSmsdeliveryErrorResponse : IErrorResponse<StartQueuedSmsdeliveryError>
{
    public static StartQueuedSmsdeliveryErrorResponse Instance { get; } = new();

    private StartQueuedSmsdeliveryErrorResponse()
    {
    }

    public Task<StartQueuedSmsdeliveryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        StartQueuedSmsdeliveryError.Create(response, ct);
}
