using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UnregisterDiagnosticsCallbackError : ApiError
{
    private readonly Optional<DeviceDiagnosticsResult> _deviceDiagnosticsResultValue;

    private UnregisterDiagnosticsCallbackError(Optional<DeviceDiagnosticsResult> deviceDiagnosticsResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceDiagnosticsResultValue = deviceDiagnosticsResultValue;
    }

    private static UnregisterDiagnosticsCallbackError AsDeviceDiagnosticsResult(DeviceDiagnosticsResult value) =>
        new(Optional<DeviceDiagnosticsResult>.Some(value), default);

    private static UnregisterDiagnosticsCallbackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult value) =>
        _deviceDiagnosticsResultValue.TryGetValue(out value);

    internal static Task<UnregisterDiagnosticsCallbackError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceDiagnosticsResult>(response, ct).As(AsDeviceDiagnosticsResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UnregisterDiagnosticsCallbackErrorResponse : IErrorResponse<UnregisterDiagnosticsCallbackError>
{
    public static UnregisterDiagnosticsCallbackErrorResponse Instance { get; } = new();

    private UnregisterDiagnosticsCallbackErrorResponse()
    {
    }

    public Task<UnregisterDiagnosticsCallbackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UnregisterDiagnosticsCallbackError.Create(response, ct);
}
