using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListCurrentDevicesPrlVersionError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ListCurrentDevicesPrlVersionError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ListCurrentDevicesPrlVersionError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ListCurrentDevicesPrlVersionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ListCurrentDevicesPrlVersionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListCurrentDevicesPrlVersionErrorResponse : IErrorResponse<ListCurrentDevicesPrlVersionError>
{
    public static ListCurrentDevicesPrlVersionErrorResponse Instance { get; } = new();

    private ListCurrentDevicesPrlVersionErrorResponse()
    {
    }

    public Task<ListCurrentDevicesPrlVersionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListCurrentDevicesPrlVersionError.Create(response, ct);
}
