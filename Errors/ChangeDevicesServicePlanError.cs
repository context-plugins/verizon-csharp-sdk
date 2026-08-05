using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class ChangeDevicesServicePlanError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private ChangeDevicesServicePlanError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static ChangeDevicesServicePlanError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static ChangeDevicesServicePlanError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<ChangeDevicesServicePlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ChangeDevicesServicePlanErrorResponse : IErrorResponse<ChangeDevicesServicePlanError>
{
    public static ChangeDevicesServicePlanErrorResponse Instance { get; } = new();

    private ChangeDevicesServicePlanErrorResponse()
    {
    }

    public Task<ChangeDevicesServicePlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ChangeDevicesServicePlanError.Create(response, ct);
}
