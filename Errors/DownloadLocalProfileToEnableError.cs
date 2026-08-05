using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DownloadLocalProfileToEnableError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private DownloadLocalProfileToEnableError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static DownloadLocalProfileToEnableError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static DownloadLocalProfileToEnableError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<DownloadLocalProfileToEnableError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DownloadLocalProfileToEnableErrorResponse : IErrorResponse<DownloadLocalProfileToEnableError>
{
    public static DownloadLocalProfileToEnableErrorResponse Instance { get; } = new();

    private DownloadLocalProfileToEnableErrorResponse()
    {
    }

    public Task<DownloadLocalProfileToEnableError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DownloadLocalProfileToEnableError.Create(response, ct);
}
