<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceDiagnostics — operations

Accessor: `client.DeviceDiagnostics` · Source: `Api/DeviceDiagnostics.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceReachabilityStatusUsingPost

- **Signature**: `DeviceReachabilityStatusUsingPost(NotificationReportStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<DeviceReachabilityStatusUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NotificationReportStatusRequest` | `Models/NotificationReportStatusRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `DeviceReachabilityStatusUsingPostError` | `Errors/DeviceReachabilityStatusUsingPostError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### RetrieveActiveMonitorsUsingPost

- **Signature**: `RetrieveActiveMonitorsUsingPost(RetrieveMonitorsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeviceManagementResult`
- **Error**: `SdkException<RetrieveActiveMonitorsUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveMonitorsRequest` | `Models/RetrieveMonitorsRequest.cs` |
| `DeviceManagementResult` | `Models/DeviceManagementResult.cs` |
| `RetrieveActiveMonitorsUsingPostError` | `Errors/RetrieveActiveMonitorsUsingPostError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

