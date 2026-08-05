using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeactivateServiceForDevicesError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private DeactivateServiceForDevicesError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static DeactivateServiceForDevicesError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static DeactivateServiceForDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<DeactivateServiceForDevicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeactivateServiceForDevicesErrorResponse : IErrorResponse<DeactivateServiceForDevicesError>
{
    public static DeactivateServiceForDevicesErrorResponse Instance { get; } = new();

    private DeactivateServiceForDevicesErrorResponse()
    {
    }

    public Task<DeactivateServiceForDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeactivateServiceForDevicesError.Create(response, ct);
}
