using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetCurrentAsynchronousRequestStatusError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private GetCurrentAsynchronousRequestStatusError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static GetCurrentAsynchronousRequestStatusError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static GetCurrentAsynchronousRequestStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<GetCurrentAsynchronousRequestStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCurrentAsynchronousRequestStatusErrorResponse : IErrorResponse<GetCurrentAsynchronousRequestStatusError>
{
    public static GetCurrentAsynchronousRequestStatusErrorResponse Instance { get; } = new();

    private GetCurrentAsynchronousRequestStatusErrorResponse()
    {
    }

    public Task<GetCurrentAsynchronousRequestStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCurrentAsynchronousRequestStatusError.Create(response, ct);
}
