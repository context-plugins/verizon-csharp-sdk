using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RestoreServiceForSuspendedDevicesError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private RestoreServiceForSuspendedDevicesError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static RestoreServiceForSuspendedDevicesError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static RestoreServiceForSuspendedDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<RestoreServiceForSuspendedDevicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RestoreServiceForSuspendedDevicesErrorResponse : IErrorResponse<RestoreServiceForSuspendedDevicesError>
{
    public static RestoreServiceForSuspendedDevicesErrorResponse Instance { get; } = new();

    private RestoreServiceForSuspendedDevicesErrorResponse()
    {
    }

    public Task<RestoreServiceForSuspendedDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RestoreServiceForSuspendedDevicesError.Create(response, ct);
}
