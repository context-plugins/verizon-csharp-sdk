using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListDevicesSmsmessagesError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ListDevicesSmsmessagesError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ListDevicesSmsmessagesError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ListDevicesSmsmessagesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ListDevicesSmsmessagesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListDevicesSmsmessagesErrorResponse : IErrorResponse<ListDevicesSmsmessagesError>
{
    public static ListDevicesSmsmessagesErrorResponse Instance { get; } = new();

    private ListDevicesSmsmessagesErrorResponse()
    {
    }

    public Task<ListDevicesSmsmessagesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListDevicesSmsmessagesError.Create(response, ct);
}
