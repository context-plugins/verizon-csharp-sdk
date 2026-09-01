<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsDevices — operations

Accessor: `client.SensorInsightsDevices` · Source: `Api/SensorInsightsDevices.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsDeviceActionSetRequest

- **Signature**: `SensorInsightsDeviceActionSetRequest(DmV1DevicesActionsSetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoDeviceActionSetResponse`
- **Error**: `SdkException<SensorInsightsDeviceActionSetRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DmV1DevicesActionsSetRequest` | `Models/AnyOf/DmV1DevicesActionsSetRequest.cs` |
| `DtoDeviceActionSetResponse` | `Models/DtoDeviceActionSetResponse.cs` |
| `SensorInsightsDeviceActionSetRequestError` | `Errors/SensorInsightsDeviceActionSetRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |

### SensorInsightsLastReportedTimeRequest

- **Signature**: `SensorInsightsLastReportedTimeRequest(DtoLastReportedTimeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoLastReportedTimeResponse`
- **Error**: `SdkException<SensorInsightsLastReportedTimeRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoLastReportedTimeRequest` | `Models/DtoLastReportedTimeRequest.cs` |
| `DtoLastReportedTimeResponse` | `Models/DtoLastReportedTimeResponse.cs` |
| `SensorInsightsLastReportedTimeRequestError` | `Errors/SensorInsightsLastReportedTimeRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |

### SensorInsightsListDeviceExperienceHistoryRequest

- **Signature**: `SensorInsightsListDeviceExperienceHistoryRequest(DtoListDeviceExperienceHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<UserDeviceExperienceHistory>`
- **Error**: `SdkException<SensorInsightsListDeviceExperienceHistoryRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListDeviceExperienceHistoryRequest` | `Models/DtoListDeviceExperienceHistoryRequest.cs` |
| `UserDeviceExperienceHistory` | `Models/UserDeviceExperienceHistory.cs` |
| `SensorInsightsListDeviceExperienceHistoryRequestError` | `Errors/SensorInsightsListDeviceExperienceHistoryRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsListDevicesRequest

- **Signature**: `SensorInsightsListDevicesRequest(DtoListDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DtoExpandedDeviceResponse>`
- **Error**: `SdkException<SensorInsightsListDevicesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError(out ManagementError)` [400, 401, 403, 404, 406, 415, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListDevicesRequest` | `Models/DtoListDevicesRequest.cs` |
| `DtoExpandedDeviceResponse` | `Models/DtoExpandedDeviceResponse.cs` |
| `SensorInsightsListDevicesRequestError` | `Errors/SensorInsightsListDevicesRequestError.cs` |
| `ManagementError` | `Models/ManagementError.cs` |

### SensorInsightsListNetworkExperienceHistoryRequest

- **Signature**: `SensorInsightsListNetworkExperienceHistoryRequest(DtoListNetworkExperienceHistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<UserNetworkExperienceHistory>`
- **Error**: `SdkException<SensorInsightsListNetworkExperienceHistoryRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListNetworkExperienceHistoryRequest` | `Models/DtoListNetworkExperienceHistoryRequest.cs` |
| `UserNetworkExperienceHistory` | `Models/UserNetworkExperienceHistory.cs` |
| `SensorInsightsListNetworkExperienceHistoryRequestError` | `Errors/SensorInsightsListNetworkExperienceHistoryRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsPatchDeviceRequest

- **Signature**: `SensorInsightsPatchDeviceRequest(DtoPatchDeviceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResourceDevice`
- **Error**: `SdkException<SensorInsightsPatchDeviceRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoPatchDeviceRequest` | `Models/DtoPatchDeviceRequest.cs` |
| `ResourceDevice` | `Models/ResourceDevice.cs` |
| `SensorInsightsPatchDeviceRequestError` | `Errors/SensorInsightsPatchDeviceRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

