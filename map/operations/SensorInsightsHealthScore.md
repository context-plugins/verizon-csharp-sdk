<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsHealthScore — operations

Accessor: `client.SensorInsightsHealthScore` · Source: `Api/SensorInsightsHealthScore.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsGetNetworkHealthScoreResponse

- **Signature**: `SensorInsightsGetNetworkHealthScoreResponse(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoGetNetworkHealthScoreResponse`
- **Error**: `SdkException<SensorInsightsGetNetworkHealthScoreResponseError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoGetNetworkHealthScoreResponse` | `Models/DtoGetNetworkHealthScoreResponse.cs` |
| `SensorInsightsGetNetworkHealthScoreResponseError` | `Errors/SensorInsightsGetNetworkHealthScoreResponseError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsHealthScoreSummary

- **Signature**: `SensorInsightsHealthScoreSummary(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoHealthScoreSummary`
- **Error**: `SdkException<SensorInsightsHealthScoreSummaryError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoHealthScoreSummary` | `Models/DtoHealthScoreSummary.cs` |
| `SensorInsightsHealthScoreSummaryError` | `Errors/SensorInsightsHealthScoreSummaryError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

