using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SensorInsightsListDevicesRequestError : ApiError
{
    private readonly Optional<ManagementError> _managementErrorValue;

    private SensorInsightsListDevicesRequestError(Optional<ManagementError> managementErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _managementErrorValue = managementErrorValue;
    }

    private static SensorInsightsListDevicesRequestError AsManagementError(ManagementError value) =>
        new(Optional<ManagementError>.Some(value), default);

    private static SensorInsightsListDevicesRequestError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetManagementError(out ManagementError value) =>
        _managementErrorValue.TryGetValue(out value);

    internal static Task<SensorInsightsListDevicesRequestError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 415 or 429 or 500 => FromJson<ManagementError>(response, ct).As(AsManagementError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SensorInsightsListDevicesRequestErrorResponse : IErrorResponse<SensorInsightsListDevicesRequestError>
{
    public static SensorInsightsListDevicesRequestErrorResponse Instance { get; } = new();

    private SensorInsightsListDevicesRequestErrorResponse()
    {
    }

    public Task<SensorInsightsListDevicesRequestError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SensorInsightsListDevicesRequestError.Create(response, ct);
}
