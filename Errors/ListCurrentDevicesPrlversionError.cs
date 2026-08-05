using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListCurrentDevicesPrlversionError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ListCurrentDevicesPrlversionError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ListCurrentDevicesPrlversionError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ListCurrentDevicesPrlversionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ListCurrentDevicesPrlversionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListCurrentDevicesPrlversionErrorResponse : IErrorResponse<ListCurrentDevicesPrlversionError>
{
    public static ListCurrentDevicesPrlversionErrorResponse Instance { get; } = new();

    private ListCurrentDevicesPrlversionErrorResponse()
    {
    }

    public Task<ListCurrentDevicesPrlversionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListCurrentDevicesPrlversionError.Create(response, ct);
}
