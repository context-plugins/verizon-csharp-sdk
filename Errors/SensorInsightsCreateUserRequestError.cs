using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class SensorInsightsCreateUserRequestError : ApiError
{
    private readonly Optional<ManagementError400> _managementError400Value;

    private readonly Optional<ManagementError> _managementErrorValue;

    private readonly Optional<ManagementError403> _managementError403Value;

    private readonly Optional<ManagementError500> _managementError500Value;

    private SensorInsightsCreateUserRequestError(Optional<ManagementError400> managementError400Value,
        Optional<ManagementError> managementErrorValue,
        Optional<ManagementError403> managementError403Value,
        Optional<ManagementError500> managementError500Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _managementError400Value = managementError400Value;
        _managementErrorValue = managementErrorValue;
        _managementError403Value = managementError403Value;
        _managementError500Value = managementError500Value;
    }

    private static SensorInsightsCreateUserRequestError AsManagementError400(ManagementError400 value) =>
        new(Optional<ManagementError400>.Some(value), default, default, default, default);

    private static SensorInsightsCreateUserRequestError AsManagementError(ManagementError value) =>
        new(default, Optional<ManagementError>.Some(value), default, default, default);

    private static SensorInsightsCreateUserRequestError AsManagementError403(ManagementError403 value) =>
        new(default, default, Optional<ManagementError403>.Some(value), default, default);

    private static SensorInsightsCreateUserRequestError AsManagementError500(ManagementError500 value) =>
        new(default, default, default, Optional<ManagementError500>.Some(value), default);

    private static SensorInsightsCreateUserRequestError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetManagementError400(out ManagementError400 value) =>
        _managementError400Value.TryGetValue(out value);

    public bool TryGetManagementError(out ManagementError value) =>
        _managementErrorValue.TryGetValue(out value);

    public bool TryGetManagementError403(out ManagementError403 value) =>
        _managementError403Value.TryGetValue(out value);

    public bool TryGetManagementError500(out ManagementError500 value) =>
        _managementError500Value.TryGetValue(out value);

    internal static Task<SensorInsightsCreateUserRequestError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ManagementError400>(response, ct).As(AsManagementError400),
            401 or 406 or 415 or 429 => FromJson<ManagementError>(response, ct).As(AsManagementError),
            403 => FromJson<ManagementError403>(response, ct).As(AsManagementError403),
            500 => FromJson<ManagementError500>(response, ct).As(AsManagementError500),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SensorInsightsCreateUserRequestErrorResponse : IErrorResponse<SensorInsightsCreateUserRequestError>
{
    public static SensorInsightsCreateUserRequestErrorResponse Instance { get; } = new();

    private SensorInsightsCreateUserRequestErrorResponse()
    {
    }

    public Task<SensorInsightsCreateUserRequestError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SensorInsightsCreateUserRequestError.Create(response, ct);
}
