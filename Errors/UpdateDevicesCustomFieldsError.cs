using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UpdateDevicesCustomFieldsError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private UpdateDevicesCustomFieldsError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static UpdateDevicesCustomFieldsError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static UpdateDevicesCustomFieldsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<UpdateDevicesCustomFieldsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateDevicesCustomFieldsErrorResponse : IErrorResponse<UpdateDevicesCustomFieldsError>
{
    public static UpdateDevicesCustomFieldsErrorResponse Instance { get; } = new();

    private UpdateDevicesCustomFieldsErrorResponse()
    {
    }

    public Task<UpdateDevicesCustomFieldsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateDevicesCustomFieldsError.Create(response, ct);
}
