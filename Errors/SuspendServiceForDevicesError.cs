using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SuspendServiceForDevicesError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private SuspendServiceForDevicesError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static SuspendServiceForDevicesError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static SuspendServiceForDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<SuspendServiceForDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SuspendServiceForDevicesErrorResponse : IErrorResponse<SuspendServiceForDevicesError>
{
    public static SuspendServiceForDevicesErrorResponse Instance { get; } = new();

    private SuspendServiceForDevicesErrorResponse()
    {
    }

    public Task<SuspendServiceForDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SuspendServiceForDevicesError.Create(response, ct);
}
