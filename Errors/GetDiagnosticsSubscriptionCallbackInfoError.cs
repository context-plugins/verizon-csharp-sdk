using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetDiagnosticsSubscriptionCallbackInfoError : ApiError
{
    private readonly Optional<DeviceDiagnosticsResult> _deviceDiagnosticsResultValue;

    private GetDiagnosticsSubscriptionCallbackInfoError(Optional<DeviceDiagnosticsResult> deviceDiagnosticsResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deviceDiagnosticsResultValue = deviceDiagnosticsResultValue;
    }

    private static GetDiagnosticsSubscriptionCallbackInfoError AsDeviceDiagnosticsResult(DeviceDiagnosticsResult value) =>
        new(Optional<DeviceDiagnosticsResult>.Some(value), default);

    private static GetDiagnosticsSubscriptionCallbackInfoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDeviceDiagnosticsResult(out DeviceDiagnosticsResult value) =>
        _deviceDiagnosticsResultValue.TryGetValue(out value);

    internal static Task<GetDiagnosticsSubscriptionCallbackInfoError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeviceDiagnosticsResult>(response, ct).As(AsDeviceDiagnosticsResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDiagnosticsSubscriptionCallbackInfoErrorResponse : IErrorResponse<GetDiagnosticsSubscriptionCallbackInfoError>
{
    public static GetDiagnosticsSubscriptionCallbackInfoErrorResponse Instance { get; } = new();

    private GetDiagnosticsSubscriptionCallbackInfoErrorResponse()
    {
    }

    public Task<GetDiagnosticsSubscriptionCallbackInfoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDiagnosticsSubscriptionCallbackInfoError.Create(response, ct);
}
