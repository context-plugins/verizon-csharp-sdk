<!-- Generated file — do not edit; regenerated with the SDK. -->

# DevicesLocations — operations

Accessor: `client.DevicesLocations` · Source: `Api/DevicesLocations.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelQueuedLocationReportGeneration

- **Server group**: `DeviceLocation`
- **Signature**: `CancelQueuedLocationReportGeneration(string accountName, string txid, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionId` | `Models/TransactionId.cs` |

### CreateLocationReport

- **Server group**: `DeviceLocation`
- **Signature**: `CreateLocationReport(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AsynchronousLocationRequestResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AsynchronousLocationRequestResult` | `Models/AsynchronousLocationRequestResult.cs` |

### GetLocationReportStatus

- **Server group**: `DeviceLocation`
- **Signature**: `GetLocationReportStatus(string accountName, string txid, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LocationReportStatus`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LocationReportStatus` | `Models/LocationReportStatus.cs` |

### ListDevicesLocationsAsynchronous

- **Server group**: `DeviceLocation`
- **Signature**: `ListDevicesLocationsAsynchronous(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SynchronousLocationRequestResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SynchronousLocationRequestResult` | `Models/SynchronousLocationRequestResult.cs` |

### ListDevicesLocationsSynchronous

- **Server group**: `DeviceLocation`
- **Signature**: `ListDevicesLocationsSynchronous(LocationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Location>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LocationRequest` | `Models/LocationRequest.cs` |
| `Location` | `Models/Location.cs` |

### RetrieveLocationReport

- **Server group**: `DeviceLocation`
- **Signature**: `RetrieveLocationReport(string accountName, string txid, int startindex, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LocationReport`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LocationReport` | `Models/LocationReport.cs` |

