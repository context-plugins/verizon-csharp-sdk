using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ResetConnectivityManagementPasswordError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ResetConnectivityManagementPasswordError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ResetConnectivityManagementPasswordError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ResetConnectivityManagementPasswordError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ResetConnectivityManagementPasswordError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ResetConnectivityManagementPasswordErrorResponse : IErrorResponse<ResetConnectivityManagementPasswordError>
{
    public static ResetConnectivityManagementPasswordErrorResponse Instance { get; } = new();

    private ResetConnectivityManagementPasswordErrorResponse()
    {
    }

    public Task<ResetConnectivityManagementPasswordError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ResetConnectivityManagementPasswordError.Create(response, ct);
}
