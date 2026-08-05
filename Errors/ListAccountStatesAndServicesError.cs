using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ListAccountStatesAndServicesError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ListAccountStatesAndServicesError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ListAccountStatesAndServicesError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ListAccountStatesAndServicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ListAccountStatesAndServicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAccountStatesAndServicesErrorResponse : IErrorResponse<ListAccountStatesAndServicesError>
{
    public static ListAccountStatesAndServicesErrorResponse Instance { get; } = new();

    private ListAccountStatesAndServicesErrorResponse()
    {
    }

    public Task<ListAccountStatesAndServicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAccountStatesAndServicesError.Create(response, ct);
}
