using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RetrieveActiveMonitorsUsingPostError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private RetrieveActiveMonitorsUsingPostError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static RetrieveActiveMonitorsUsingPostError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static RetrieveActiveMonitorsUsingPostError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<RetrieveActiveMonitorsUsingPostError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RetrieveActiveMonitorsUsingPostErrorResponse : IErrorResponse<RetrieveActiveMonitorsUsingPostError>
{
    public static RetrieveActiveMonitorsUsingPostErrorResponse Instance { get; } = new();

    private RetrieveActiveMonitorsUsingPostErrorResponse()
    {
    }

    public Task<RetrieveActiveMonitorsUsingPostError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RetrieveActiveMonitorsUsingPostError.Create(response, ct);
}
