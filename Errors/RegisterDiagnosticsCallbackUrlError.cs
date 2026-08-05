using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RegisterDiagnosticsCallbackUrlError : ApiError
{
    private readonly Optional<DeviceDiagnosticsResult> _deviceDiagnosticsResultValue;

    private RegisterDiagnosticsCallbackUrlError(Optional<DeviceDiagnosticsResult> deviceDiagnosticsResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceDiagnosticsResultValue = deviceDiagnosticsResultValue;
    }

    private static RegisterDiagnosticsCallbackUrlError AsDeviceDiagnosticsResult(DeviceDiagnosticsResult value) =>
        new(Optional<DeviceDiagnosticsResult>.Some(value), default);

    private static RegisterDiagnosticsCallbackUrlError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult value) =>
        _deviceDiagnosticsResultValue.TryGetValue(out value);

    internal static Task<RegisterDiagnosticsCallbackUrlError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceDiagnosticsResult>(response, ct).As(AsDeviceDiagnosticsResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RegisterDiagnosticsCallbackUrlErrorResponse : IErrorResponse<RegisterDiagnosticsCallbackUrlError>
{
    public static RegisterDiagnosticsCallbackUrlErrorResponse Instance { get; } = new();

    private RegisterDiagnosticsCallbackUrlErrorResponse()
    {
    }

    public Task<RegisterDiagnosticsCallbackUrlError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RegisterDiagnosticsCallbackUrlError.Create(response, ct);
}
