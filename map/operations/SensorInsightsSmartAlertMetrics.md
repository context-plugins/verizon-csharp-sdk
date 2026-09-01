<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsSmartAlertMetrics — operations

Accessor: `client.SensorInsightsSmartAlertMetrics` · Source: `Api/SensorInsightsSmartAlertMetrics.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Sensorinsightsmetricsquery

- **Signature**: `Sensorinsightsmetricsquery(DtoQueryMetrics body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoQueryMetricsResponse`
- **Error**: `SdkException<SensorinsightsmetricsqueryError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoQueryMetrics` | `Models/DtoQueryMetrics.cs` |
| `DtoQueryMetricsResponse` | `Models/DtoQueryMetricsResponse.cs` |
| `SensorinsightsmetricsqueryError` | `Errors/SensorinsightsmetricsqueryError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

