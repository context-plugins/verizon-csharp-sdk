<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceMonitoring — operations

Accessor: `client.DeviceMonitoring` · Source: `Api/DeviceMonitoring.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceReachability

- **Signature**: `DeviceReachability(NotificationReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<DeviceReachabilityError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NotificationReportRequest` | `Models/NotificationReportRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `DeviceReachabilityError` | `Errors/DeviceReachabilityError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### StopDeviceReachability

- **Signature**: `StopDeviceReachability(StopMonitorRequest stopreachabilitypayload, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `stopreachabilitypayload` ← `stopreachabilitypayload`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<StopDeviceReachabilityError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `StopMonitorRequest` | `Models/StopMonitorRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `StopDeviceReachabilityError` | `Errors/StopDeviceReachabilityError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

