using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class StartConnectivityManagementSessionError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private StartConnectivityManagementSessionError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static StartConnectivityManagementSessionError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static StartConnectivityManagementSessionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<StartConnectivityManagementSessionError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class StartConnectivityManagementSessionErrorResponse : IErrorResponse<StartConnectivityManagementSessionError>
{
    public static StartConnectivityManagementSessionErrorResponse Instance { get; } = new();

    private StartConnectivityManagementSessionErrorResponse()
    {
    }

    public Task<StartConnectivityManagementSessionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        StartConnectivityManagementSessionError.Create(response, ct);
}
