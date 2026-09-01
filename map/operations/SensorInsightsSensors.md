<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsSensors — operations

Accessor: `client.SensorInsightsSensors` · Source: `Api/SensorInsightsSensors.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsListSensorDevicesRequest

- **Signature**: `SensorInsightsListSensorDevicesRequest(DtoListSensorDevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ResourceDevice>`
- **Error**: `SdkException<SensorInsightsListSensorDevicesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListSensorDevicesRequest` | `Models/DtoListSensorDevicesRequest.cs` |
| `ResourceDevice` | `Models/ResourceDevice.cs` |
| `SensorInsightsListSensorDevicesRequestError` | `Errors/SensorInsightsListSensorDevicesRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsOffBoardSensorRequest

- **Signature**: `SensorInsightsOffBoardSensorRequest(DtoOffBoardSensorRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SensorInsightsOffBoardSensorRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoOffBoardSensorRequest` | `Models/DtoOffBoardSensorRequest.cs` |
| `SensorInsightsOffBoardSensorRequestError` | `Errors/SensorInsightsOffBoardSensorRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |

### SensorInsightsOnBoardSensorRequest

- **Signature**: `SensorInsightsOnBoardSensorRequest(DtoOnBoardSensorRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SensorInsightsOnBoardSensorRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoOnBoardSensorRequest` | `Models/DtoOnBoardSensorRequest.cs` |
| `SensorInsightsOnBoardSensorRequestError` | `Errors/SensorInsightsOnBoardSensorRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsSensorOffBoardingStatusRequest

- **Signature**: `SensorInsightsSensorOffBoardingStatusRequest(DtoSensorOffBoardStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoSensorOffBoardingStatusResponse`
- **Error**: `SdkException<SensorInsightsSensorOffBoardingStatusRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoSensorOffBoardStatusRequest` | `Models/DtoSensorOffBoardStatusRequest.cs` |
| `DtoSensorOffBoardingStatusResponse` | `Models/DtoSensorOffBoardingStatusResponse.cs` |
| `SensorInsightsSensorOffBoardingStatusRequestError` | `Errors/SensorInsightsSensorOffBoardingStatusRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsSensorOnBoardStatusRequest

- **Signature**: `SensorInsightsSensorOnBoardStatusRequest(DtoSensorOnBoardStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DtoSensorOnBoardingStatusResponse`
- **Error**: `SdkException<SensorInsightsSensorOnBoardStatusRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoSensorOnBoardStatusRequest` | `Models/DtoSensorOnBoardStatusRequest.cs` |
| `DtoSensorOnBoardingStatusResponse` | `Models/DtoSensorOnBoardingStatusResponse.cs` |
| `SensorInsightsSensorOnBoardStatusRequestError` | `Errors/SensorInsightsSensorOnBoardStatusRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

