using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteDeactivatedDevicesError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private DeleteDeactivatedDevicesError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static DeleteDeactivatedDevicesError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static DeleteDeactivatedDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<DeleteDeactivatedDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteDeactivatedDevicesErrorResponse : IErrorResponse<DeleteDeactivatedDevicesError>
{
    public static DeleteDeactivatedDevicesErrorResponse Instance { get; } = new();

    private DeleteDeactivatedDevicesErrorResponse()
    {
    }

    public Task<DeleteDeactivatedDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteDeactivatedDevicesError.Create(response, ct);
}
