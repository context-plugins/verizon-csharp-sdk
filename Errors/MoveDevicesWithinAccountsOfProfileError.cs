using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class MoveDevicesWithinAccountsOfProfileError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private MoveDevicesWithinAccountsOfProfileError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static MoveDevicesWithinAccountsOfProfileError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static MoveDevicesWithinAccountsOfProfileError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<MoveDevicesWithinAccountsOfProfileError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MoveDevicesWithinAccountsOfProfileErrorResponse : IErrorResponse<MoveDevicesWithinAccountsOfProfileError>
{
    public static MoveDevicesWithinAccountsOfProfileErrorResponse Instance { get; } = new();

    private MoveDevicesWithinAccountsOfProfileErrorResponse()
    {
    }

    public Task<MoveDevicesWithinAccountsOfProfileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MoveDevicesWithinAccountsOfProfileError.Create(response, ct);
}
