using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SensorInsightsOffBoardSensorRequestError : ApiError
{
    private readonly Optional<ManagementError400> _managementError400Value;

    private readonly Optional<ManagementError> _managementErrorValue;

    private readonly Optional<ManagementError403> _managementError403Value;

    private SensorInsightsOffBoardSensorRequestError(Optional<ManagementError400> managementError400Value,
        Optional<ManagementError> managementErrorValue,
        Optional<ManagementError403> managementError403Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _managementError400Value = managementError400Value;
        _managementErrorValue = managementErrorValue;
        _managementError403Value = managementError403Value;
    }

    private static SensorInsightsOffBoardSensorRequestError AsManagementError400(ManagementError400 value) =>
        new(Optional<ManagementError400>.Some(value), default, default, default);

    private static SensorInsightsOffBoardSensorRequestError AsManagementError(ManagementError value) =>
        new(default, Optional<ManagementError>.Some(value), default, default);

    private static SensorInsightsOffBoardSensorRequestError AsManagementError403(ManagementError403 value) =>
        new(default, default, Optional<ManagementError403>.Some(value), default);

    private static SensorInsightsOffBoardSensorRequestError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetManagementError400(out ManagementError400 value) =>
        _managementError400Value.TryGetValue(out value);

    public bool TryGetManagementError(out ManagementError value) =>
        _managementErrorValue.TryGetValue(out value);

    public bool TryGetManagementError403(out ManagementError403 value) =>
        _managementError403Value.TryGetValue(out value);

    internal static Task<SensorInsightsOffBoardSensorRequestError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ManagementError400>(response, ct).As(AsManagementError400),
            401 => FromJson<ManagementError>(response, ct).As(AsManagementError),
            403 => FromJson<ManagementError403>(response, ct).As(AsManagementError403),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SensorInsightsOffBoardSensorRequestErrorResponse : IErrorResponse<SensorInsightsOffBoardSensorRequestError>
{
    public static SensorInsightsOffBoardSensorRequestErrorResponse Instance { get; } = new();

    private SensorInsightsOffBoardSensorRequestErrorResponse()
    {
    }

    public Task<SensorInsightsOffBoardSensorRequestError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SensorInsightsOffBoardSensorRequestError.Create(response, ct);
}
