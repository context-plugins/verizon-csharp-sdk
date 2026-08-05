using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DownloadLocalProfileToDisableError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private DownloadLocalProfileToDisableError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static DownloadLocalProfileToDisableError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static DownloadLocalProfileToDisableError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<DownloadLocalProfileToDisableError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DownloadLocalProfileToDisableErrorResponse : IErrorResponse<DownloadLocalProfileToDisableError>
{
    public static DownloadLocalProfileToDisableErrorResponse Instance { get; } = new();

    private DownloadLocalProfileToDisableErrorResponse()
    {
    }

    public Task<DownloadLocalProfileToDisableError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DownloadLocalProfileToDisableError.Create(response, ct);
}
