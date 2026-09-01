<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsSmartAlerts — operations

Accessor: `client.SensorInsightsSmartAlerts` · Source: `Api/SensorInsightsSmartAlerts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsBulkUpdate

- **Signature**: `SensorInsightsBulkUpdate(DtoBulkUpdate body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserSmartAlert`
- **Error**: `SdkException<SensorInsightsBulkUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoBulkUpdate` | `Models/DtoBulkUpdate.cs` |
| `UserSmartAlert` | `Models/UserSmartAlert.cs` |
| `SensorInsightsBulkUpdateError` | `Errors/SensorInsightsBulkUpdateError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsListSmartAlertsRequest

- **Signature**: `SensorInsightsListSmartAlertsRequest(DtoListSmartAlertsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<UserSmartAlert>`
- **Error**: `SdkException<SensorInsightsListSmartAlertsRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListSmartAlertsRequest` | `Models/DtoListSmartAlertsRequest.cs` |
| `UserSmartAlert` | `Models/UserSmartAlert.cs` |
| `SensorInsightsListSmartAlertsRequestError` | `Errors/SensorInsightsListSmartAlertsRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsPatchSmartAlertRequest

- **Signature**: `SensorInsightsPatchSmartAlertRequest(DtoPatchSmartAlertRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserSmartAlert`
- **Error**: `SdkException<SensorInsightsPatchSmartAlertRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoPatchSmartAlertRequest` | `Models/DtoPatchSmartAlertRequest.cs` |
| `UserSmartAlert` | `Models/UserSmartAlert.cs` |
| `SensorInsightsPatchSmartAlertRequestError` | `Errors/SensorInsightsPatchSmartAlertRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

