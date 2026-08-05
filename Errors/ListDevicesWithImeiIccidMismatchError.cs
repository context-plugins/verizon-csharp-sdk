using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListDevicesWithImeiIccidMismatchError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ListDevicesWithImeiIccidMismatchError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ListDevicesWithImeiIccidMismatchError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ListDevicesWithImeiIccidMismatchError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ListDevicesWithImeiIccidMismatchError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListDevicesWithImeiIccidMismatchErrorResponse : IErrorResponse<ListDevicesWithImeiIccidMismatchError>
{
    public static ListDevicesWithImeiIccidMismatchErrorResponse Instance { get; } = new();

    private ListDevicesWithImeiIccidMismatchErrorResponse()
    {
    }

    public Task<ListDevicesWithImeiIccidMismatchError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListDevicesWithImeiIccidMismatchError.Create(response, ct);
}
